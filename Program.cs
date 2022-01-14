using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Chailease.Insurce;
using Newtonsoft.Json;

namespace CreditScriptDotNet5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string charsEnglish = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0";

            ////決定要連哪個blob
            //Console.WriteLine("Env(1：dev，2：demo，3：demo-my)：");
            //var Env = Console.ReadLine();
            //int env = string.IsNullOrEmpty(Env) ? 1 : Int32.Parse(Env);
            //string connectionString = string.Empty;
            //switch (env)
            //{
            //    case 1:
            //        connectionString = "DefaultEndpointsProtocol=https;AccountName=sigvcollectionblob;AccountKey=7aQcSg2n6L+Cb/LIW8mlRlkN/StDi0DfkkgtOKhBnMYbyrMq226WyllQddl2Jz98LcDhUkOB2emqVxxdHGCzFw==;EndpointSuffix=core.windows.net"; break;
            //    case 2: connectionString = "DefaultEndpointsProtocol=https;AccountName=sasigvsit;AccountKey=HZrKvd7zvYqUzCp82LG4K7ttajceUrpZUdNRRiLxFzqD+ucWAe1jc4totp4h4yYi58/y5lp5Fmb1sqf67tcOAQ==;EndpointSuffix=core.windows.net"; break;
            //    case 3: connectionString = "DefaultEndpointsProtocol=https;AccountName=sasigvsit;AccountKey=HZrKvd7zvYqUzCp82LG4K7ttajceUrpZUdNRRiLxFzqD+ucWAe1jc4totp4h4yYi58/y5lp5Fmb1sqf67tcOAQ==;EndpointSuffix=core.windows.net"; break;
            //    default:
            //        throw new Exception("connectionString error");
            //        break;
            //}

            var result = new CreditModel();

            Console.WriteLine("Input CaseNo：");
            var caseNo = Console.ReadLine();
            result.CaseNo = caseNo;

            Console.WriteLine("Input IdentityType(I/C)：");
            var identityType = Console.ReadLine();
            result.IdentityType = identityType;

            Console.WriteLine("Input cifNo(Enter get random)：");
            var cifNo = Console.ReadLine();
            if (string.IsNullOrEmpty(cifNo) && identityType == "I")
                cifNo = "I000000000855";
            if (string.IsNullOrEmpty(cifNo) && identityType == "C")
                cifNo = "C000000000010";
            result.CifNo = cifNo;
            //隨意給值
            result.IdentificationType = "5";
            result.IdNo = "789123456";

            result.FirstName = new string(Enumerable.Repeat(charsEnglish, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            result.LastName = "";
            result.DealerCode = "MSGRMS01";
            result.DealerName = new string(Enumerable.Repeat(charsEnglish, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            result.AgentCode = new string(Enumerable.Repeat(charsEnglish, 6)
                    .Select(s => s[random.Next(s.Length)]).ToArray()) +
                    new Random().Next(99).ToString("00");
            result.AgentName = "";

            Console.WriteLine("Input CompanyId：");
            var compId = Console.ReadLine();
            result.CompanyId = string.IsNullOrEmpty(compId) ? 93 : Int32.Parse(compId);

            Console.WriteLine("Input productCode(or Enter get Default：L-011-0000)：");
            var productCode = Console.ReadLine();
            result.ProductCode = string.IsNullOrEmpty(productCode) ? "L-011-0000" : productCode;

            result.ProductName = "PC-Portfolio project";

            Console.WriteLine("Input productVersion(or Enter get Default：9)：");
            var version = Console.ReadLine();
            result.Version = string.IsNullOrEmpty(version) ? 9 : Int32.Parse(version);

            result.QuotesType = "quotesType";
            result.Currency = "MYS";
            result.TenureMonth = 60;
            result.PaymentFrequency = "1";
            result.PaymentTiming = "End of Period";
            result.PaymentDueatMonthEnd = false;
            result.SubmussionApplicantID = "MY00213";
            result.DeptID = 20617;
            result.ApplyDate = DateTime.Now;
            result.ApprovalDate = DateTime.Now;
            result.InterestFlatRate = 10;
            result.ApprovalFinanceAmount = 29000;
            result.ApprovalTotalAmount = 29000;
            result.AnnualPercentageRate = 0;
            result.NormalIRR = 18.16;
            result.RealIRR = 17.27;
            result.Npv = 9622.59;
            result.Autolife = true;
            result.AutolifeSumIsured = 29000;

            Console.WriteLine("Input refinancing case?(or Enter get Default：N)：");
            var refinancing = Console.ReadLine();
            if (result.Refinancing = !string.IsNullOrEmpty(refinancing))
            {
                result.SettlementContract = refinancing;
            }


            result.DealerRetention = 3000;
            result.DisburseMonth = 3;
            result.TotalPayableAmount = 10000;
            result.ProfitInterestInvoiceAmount = 100;
            result.ProfitInterestInvoiceTax = 10;
            result.CreditOfficer = "PH0001";
            result.CreditOfficerDept = 20617;
            result.AutoDebitReferenceNo = "0";
            result.CustomerIndivisual = new CustomerIndivisual();
            result.CustomerCorporate = new CustomerCorporate();

            List<Guarantor> guarantors = new List<Guarantor>();
            guarantors.Add(new Guarantor()
            {
                IdentityType = "I",
                CifNo = "I000000000987",
                IdNo = "291129186",
                IdentificationType = "5",
                FirstName = "DUNGCA, RAYMOND FERNANDEZ",
                LegalPosition = "Guarantor",
                Relationship = "Registered",
                MobilePhone = "09397657185",
                Remark = "A guarantor is someone who agrees to be responsible for your rent and your other legal obligations in a tenancy agreement"
            });

            guarantors.Add(new Guarantor()
            {
                IdentityType = "C",
                CifNo = "C000000000016",
                IdNo = "009253298",
                IdentificationType = "5",
                //custemoName
                FirstName = "CHEAPOLAND TRANSERVICE MGMT. CORP",
                LegalPosition = "Guarantor",
                Relationship = "Parents",
                MobilePhone = "09178277782",
            });
            result.Guarantor = guarantors;

            List<ContactPerson> contactPersons = new List<ContactPerson>();
            contactPersons.Add(new ContactPerson()
            {
                FirstName = "KWOKSON",
                LastName = "PABLO",
                Relationship = "Parents",
                MobilePhone = "8797616324",
            });
            contactPersons.Add(new ContactPerson()
            {
                FirstName = "NUR EL",
                LastName = "SANPABLO",
                Relationship = "Spouse",
                MobilePhone = "9746156189",
            });
            result.ContactPerson = contactPersons;

            List<Fee> fees = new List<Fee>();
            fees.Add(new Fee()
            {
                Item = "01",
                PaidBy = "D",
                Amount = 100,
                Finance = true,
                Deduct = false,
                Payment = "C"
            });
            fees.Add(new Fee()
            {
                Item = "02",
                PaidBy = "C",
                Amount = 200,
                Finance = true,
                Deduct = false,
                Payment = "Y"
            });
            fees.Add(new Fee()
            {
                Item = "03",
                PaidBy = "C",
                Amount = 300,
                Finance = true,
                Deduct = false,
                Payment = "M"
            });
            fees.Add(new Fee()
            {
                Item = "04",
                PaidBy = "D",
                Amount = 400,
                Finance = true,
                Deduct = false,
                Payment = "C"
            });
            fees.Add(new Fee()
            {
                Item = "05",
                PaidBy = "C",
                Amount = 500,
                Finance = true,
                Deduct = false,
                Payment = "C"
            });
            fees.Add(new Fee()
            {
                Item = "06",
                PaidBy = "D",
                Amount = 600,
                Finance = true,
                Deduct = false,
                Payment = "C"
            });
            fees.Add(new Fee()
            {
                Item = "07",
                PaidBy = "D",
                Amount = 725,
                Finance = true,
                Deduct = false,
                Payment = "C"
            });
            result.Fee = fees;

            List<Insurance> insurances = new List<Insurance>();
            insurances.Add(new Insurance()
            {
                InsuranceType = "AUTOLIFE",
                ChargedPremium = 200,
                ActualPremium = 200,
                Finance = true,
                Deduct = "Y",
            });
            insurances.Add(new Insurance()
            {
                InsuranceType = "Car Insurance",
                ChargedPremium = 100,
                ActualPremium = 100,
                Finance = true,
                Deduct = "Y",
            });
            result.Insurance = insurances;

            List<Incentive> incentives = new List<Incentive>();
            incentives.Add(new Incentive()
            {
                IncentiveType = "SI",
                Rate = 0,
                ProveofReceipt = false,
                ReceiptType = "Individual",
                Ewt = null,
                Amount = 200,
                AmountIncludeTax = 0
            });
            incentives.Add(new Incentive()
            {
                IncentiveType = "DI",
                Rate = 0,
                ProveofReceipt = true,
                ReceiptType = "Corporate",
                Ewt = null,
                Amount = 500,
                AmountIncludeTax = 0
            });
            result.Incentive = incentives;

            List<PaymentSchedule> schedules = new List<PaymentSchedule>();
            var payDate = DateTime.Now.Date;
            for (int i = 1; i < 61; i++)
            {
                schedules.Add(new PaymentSchedule()
                {
                    Term = i,
                    Paydate = payDate,
                    MonthlyPaymentExcludeInsurance = 725,
                    MonthlyPayment = 725
                });
                payDate.AddMonths(1);
            }
            result.PaymentSchedule = schedules;

            Console.WriteLine("Need Vchicle Collateral ? Y/N (or Enter get Default null)：");
            var vehicle = Console.ReadLine();
            bool needVehicle = string.IsNullOrEmpty(vehicle) ? false : vehicle == "Y";
            var vehicleDatas = new List<SecurityAssetVchicle>();
            var vehicleSubSeqId = new Random().Next(99997);
            if (needVehicle)
            {
                Console.WriteLine(" Y(有單)/N(無擔) (or Enter get Default N)：");
                var colleteralForAply = Console.ReadLine();
                Console.WriteLine(" 保險是否委外購買Y/N (or Enter get Default N)：");
                var insuranceType = Console.ReadLine();
                vehicleDatas.Add(new SecurityAssetVchicle()
                {
                    SubSeqId = vehicleSubSeqId.ToString(),
                    AssetProperty = "securityAsset",
                    AssetType = "Vehicle",
                    AssetCategory = "Motor",
                    ColleteralForAply = String.IsNullOrWhiteSpace(colleteralForAply) ? "N" : colleteralForAply,
                    Purpose = "Self-use",
                    Brand = "BR4",
                    Model = "MD60",
                    VehicleType = "Passenger Car",
                    Transaction = "New",
                    DateManufacture = DateTimeOffset.Now.AddYears(-2),
                    Age = 2,
                    Cap = 5,
                    ManufacturerNationality = "EU",
                    Displacement = 0,
                    Transmission = "Auto",
                    Gasoline = "Diesel",
                    VehicleColor = "Black",
                    Seats = 5,
                    Ton = 2,
                    PlatNo = "BJJ-5555",
                    PurchasePrice = "350000",
                    SalesAppraisalPrice = 40000,
                    Insurance = String.IsNullOrWhiteSpace(insuranceType) ? "N" : insuranceType,
                    RegistrationType = "Chattel Mortgage",
                    SecurityAssetVchicleFee = new List<SecurityAssetVchicleFee>(),
                });
            }
            result.SecurityAssetVchicle = vehicleDatas;

            Console.WriteLine("Need Movable Collateral ? Y/N (or Enter get Default null)：");
            var movable = Console.ReadLine();
            bool needMovable = string.IsNullOrEmpty(movable) ? false : movable == "Y";
            var movableDatas = new List<SecurityAssetMovable>();
            var movableSubSeqId = vehicleSubSeqId + 1;
            if (needMovable)
            {
                Console.WriteLine(" Y(有單)/N(無擔) (or Enter get Default N)：");
                var colleteralForAply = Console.ReadLine();
                movableDatas.Add(new SecurityAssetMovable()
                {
                    SubSeqId = movableSubSeqId.ToString(),
                    AssetProperty = "Financial Asset",
                    AssetType = "Movable Asset",
                    AssetCategory = "Heavy Motor",
                    ColleteralForAply = String.IsNullOrWhiteSpace(colleteralForAply) ? "N" : colleteralForAply,
                    Purpose = "Business",
                    AssetName = "Mitsubishi Dozer",
                    Brand = "BR31",
                    Model = "MD511",
                    ManufactureYear = 2000,
                    CountryofOrigin = "JPN",
                    UnitPrice = 550000,
                    MarketPrice = 490000,
                    SecurityAssetMovableFee = new List<SecurityAssetMovableFee>()
                });
            }
            result.SecurityAssetMovable = movableDatas;

            Console.WriteLine("Need RealEstate Collateral ? Y/N (or Enter get Default null)：");
            var realEstate = Console.ReadLine();
            bool needRealEstate = string.IsNullOrEmpty(realEstate) ? false : realEstate == "Y";
            var realEstateDatas = new List<SecurityAssetRealEstate>();
            var realEstateSubSeqId = movableSubSeqId + 1;
            if (needMovable)
            {
                Console.WriteLine(" Y(有單)/N(無擔) (or Enter get Default N)：");
                var colleteralForAply = Console.ReadLine();
                realEstateDatas.Add(new SecurityAssetRealEstate()
                {
                    SubSeqId = movableSubSeqId.ToString(),
                    AssetProperty = "Financial Asset",
                    AssetType = "Real Estate",
                    AssetCategory = "STD",
                    ColleteralForAply = String.IsNullOrWhiteSpace(colleteralForAply) ? "N" : colleteralForAply,
                    Purpose = "Business",
                    Owner = "MOHAMAD NOR SYABAN BIN MOHAMAD",
                    Address = "Jalan Damansara, Bukit Kiara, 60000 Kuala Lumpur, Malysia",
                    LandSizeWidthM = 1500,
                    BuildingSizeWidthM = 250,
                    PurchasePrice = 23550,
                    MarketPrice = 23130,
                    MortgageCheck = "1",
                    SecurityAssetRealEstateFee = new List<SecurityAssetRealEstateFee>()
                });
            }
            result.SecurityAssetRealEstate = realEstateDatas;




            if (string.IsNullOrEmpty(caseNo))
                caseNo = string.Format("TEST{0}{1}",
                    DateTime.Now.ToString("yyyyMMdd"),
                    (new Random().Next(0, 100)).ToString().PadLeft(3, '0'));
            result.CaseNo = caseNo;


            string creditPath = @".\credit\";
            if (!Directory.Exists(creditPath))
            {
                System.IO.FileInfo file = new System.IO.FileInfo(creditPath);
                file.Directory.Create();
            }
            creditPath = creditPath + caseNo + ".json";
            using (StreamWriter sw = File.CreateText(creditPath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            }


            Console.WriteLine("=======================Credit Data Start=============================");
            Console.WriteLine("=======================CaseNo：" + caseNo + "=============================");
            Console.WriteLine("=======================Path：\\commencement\\credit=============================");
            Console.WriteLine();
            Console.WriteLine(JsonConvert.SerializeObject(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));

            Console.WriteLine("=======================Credit Data End=============================");
            Console.WriteLine();

            //保險
            var insuranceResult = new InsurceFeeViewModel();
            insuranceResult.CompanyId = string.IsNullOrEmpty(compId) ? 93 : Int32.Parse(compId);
            var insurceFeeList = new List<InsurceFee>();
            insurceFeeList.Add(new InsurceFee()
            {
                SubSeqId = vehicleSubSeqId,
                ContractNo = caseNo,
                PolicyNo = "12345",
                InsuranceCompany = "Insurce Co.",
                InsuranceType = "carinsurance",
                SumInsured = 10000,
                PolicyDate = DateTime.Now.AddMonths(-2),
                PolicyExpiryDate = DateTime.Now.AddMonths(+2),
                RoadTax = 0,
                RoadTaxExpiryDate = DateTime.Now.AddMonths(+2),
                ChargedPremium = 15000,
                ActuralPremium = 200,
                CommissionSharing = 30,
                InsuranceFee = 0,
                InsuranceProcessFee = 0
            });
            insurceFeeList.Add(new InsurceFee()
            {
                SubSeqId = movableSubSeqId,
                ContractNo = caseNo,
                PolicyNo = "12345",
                InsuranceCompany = "Insurce Co.",
                InsuranceType = "AUTOLIFE",
                SumInsured = 10000,
                PolicyDate = DateTime.Now.AddMonths(-2),
                PolicyExpiryDate = DateTime.Now.AddMonths(+2),
                RoadTax = 0,
                RoadTaxExpiryDate = DateTime.Now.AddMonths(+2),
                ChargedPremium = 50,
                ActuralPremium = 25,
                CommissionSharing = 10,
                InsuranceFee = 0,
                InsuranceProcessFee = 0
            });
            insuranceResult.InsurceFeeList = insurceFeeList;

            string insuranceCollateralPath = @".\Insurce\Collateral\";
            if (!Directory.Exists(insuranceCollateralPath))
            {
                System.IO.FileInfo file2 = new System.IO.FileInfo(insuranceCollateralPath);
                file2.Directory.Create();
            }
            insuranceCollateralPath = insuranceCollateralPath + "Collateral_" + caseNo + ".json";
            using (StreamWriter sw = File.CreateText(insuranceCollateralPath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(insuranceResult, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            }

            Console.WriteLine("=======================Insurance Data Start=============================");
            Console.WriteLine("=======================FileName：Collateral_" + caseNo + "=============================");
            Console.WriteLine("=======================Path：\\Insurce\\Collateral=============================");
            Console.WriteLine();
            Console.WriteLine(JsonConvert.SerializeObject(insuranceResult, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));

            Console.WriteLine("=======================Insurance Data End=============================");
            Console.WriteLine();

            var repaymentInsuranceResult = new RepaymentInsurceFee();
            repaymentInsuranceResult.CompanyId = string.IsNullOrEmpty(compId) ? 93 : Int32.Parse(compId);
            repaymentInsuranceResult.ContractNo = caseNo;
            repaymentInsuranceResult.Msg_id = "0";
            repaymentInsuranceResult.PaymentTenureType = "M";
            var tenureList = new List<TenureInsurceFee>();
            for (int i = 1; i < 61; i++)
            {
                tenureList.Add(new TenureInsurceFee()
                {
                    TenureId = i,
                    InsuranceFee = 100,
                    InsuranceProcessFee = 10,
                });
            }
            repaymentInsuranceResult.TenureList = tenureList;

            string insuranceRepaymentPath = @".\Insurce\Repayment\";
            if (!Directory.Exists(insuranceRepaymentPath))
            {
                System.IO.FileInfo file3 = new System.IO.FileInfo(insuranceRepaymentPath);
                file3.Directory.Create();
            }
            insuranceRepaymentPath = insuranceRepaymentPath + "RepaymentInsurce_" + caseNo + ".json";
            using (StreamWriter sw = File.CreateText(insuranceRepaymentPath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(repaymentInsuranceResult, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            }

            Console.WriteLine("=======================Repayment Insurance Data Start============================");
            Console.WriteLine("======================= FileName：   RepaymentInsurce_" + caseNo + "==================");
            Console.WriteLine("======================= Path：   \\Insurce\\Repayment=============================");
            Console.WriteLine();
            Console.WriteLine(JsonConvert.SerializeObject(repaymentInsuranceResult, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));

            Console.WriteLine("=======================Repayment Insurance Data End=============================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("CaseNo：");
            Console.WriteLine(caseNo);
            Console.WriteLine();
            Console.WriteLine("Insurance > Collateral file name：");
            Console.WriteLine("Collateral_" + caseNo);
            Console.WriteLine();
            Console.WriteLine("Insurance > Repayment file name：");
            Console.WriteLine("RepaymentInsurce_" + caseNo);
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.ReadLine();
        }
    }
}
