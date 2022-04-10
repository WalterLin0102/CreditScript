using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Chailease.Insurce;
using Newtonsoft.Json;
using Azure.Storage.Files.Shares;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace CreditScriptDotNet5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            const string charsEnglish = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0";
            
            string individualPath = $"D:{Path.DirectorySeparatorChar}IBM{Path.DirectorySeparatorChar}CreditScriptDotNet5{Path.DirectorySeparatorChar}IndividualUsingFile.json";
            string corporatelPath = $"D:{Path.DirectorySeparatorChar}IBM{Path.DirectorySeparatorChar}CreditScriptDotNet5{Path.DirectorySeparatorChar}CorporateUsingFile.json";

            ////決定要連哪個blob
            Console.WriteLine("Env(1：dev-ph，2：dev-my，3：demo-ph，4：demo-my)：");
            var Env = Console.ReadLine();
            int env = string.IsNullOrEmpty(Env) ? 1 : Int32.Parse(Env);
            string connectionString = string.Empty;
            string shareName = string.Empty;
            switch (env)
            {
                case 1:
                    connectionString = "DefaultEndpointsProtocol=https;AccountName=sigvcollectionblob;AccountKey=7aQcSg2n6L+Cb/LIW8mlRlkN/StDi0DfkkgtOKhBnMYbyrMq226WyllQddl2Jz98LcDhUkOB2emqVxxdHGCzFw==;EndpointSuffix=core.windows.net";
                    shareName = "ibm-dev01-mock-fs";
                    break;
                case 2:
                    connectionString = "DefaultEndpointsProtocol=https;AccountName=sigvcollectionblob;AccountKey=7aQcSg2n6L+Cb/LIW8mlRlkN/StDi0DfkkgtOKhBnMYbyrMq226WyllQddl2Jz98LcDhUkOB2emqVxxdHGCzFw==;EndpointSuffix=core.windows.net";
                    shareName = "ibm-dev01-my-mock-fs";
                    break;
                case 3:
                    connectionString = "DefaultEndpointsProtocol=https;AccountName=sasigvsit;AccountKey=HZrKvd7zvYqUzCp82LG4K7ttajceUrpZUdNRRiLxFzqD+ucWAe1jc4totp4h4yYi58/y5lp5Fmb1sqf67tcOAQ==;EndpointSuffix=core.windows.net";
                    shareName = "ibm-dev02-mock-fs";
                    break;
                case 4:
                    connectionString = "DefaultEndpointsProtocol=https;AccountName=sasigvsit;AccountKey=HZrKvd7zvYqUzCp82LG4K7ttajceUrpZUdNRRiLxFzqD+ucWAe1jc4totp4h4yYi58/y5lp5Fmb1sqf67tcOAQ==;EndpointSuffix=core.windows.net";
                    shareName = "ibm-dev02-my-mock-fs";
                    individualPath = $"D:{Path.DirectorySeparatorChar}IBM{Path.DirectorySeparatorChar}CreditScriptDotNet5{Path.DirectorySeparatorChar}IndividualUsingFile_my_demo.json";
                    corporatelPath = $"D:{Path.DirectorySeparatorChar}IBM{Path.DirectorySeparatorChar}CreditScriptDotNet5{Path.DirectorySeparatorChar}CorporateUsingFile_my_demo.json";
                    break;
                default:
                    throw new Exception("connectionString error");
                    break;
            }

            var test = new ShareClient(connectionString, shareName);

            var ads = test.GetDirectoryClient("commencement");

            var result = new GetCreditRatingResultResp();

            

            //Console.WriteLine("Input ENV(MY/PH)(Default：MY)：");
            //var ENV = Console.ReadLine();
            

            Console.WriteLine("Input CaseNo：");
            var caseNo = Console.ReadLine();
            //result.CaseNo = caseNo;

            Console.WriteLine("Input IdentityType(I/C)：(or Enter get Default：I)");
            var identityType = Console.ReadLine();
            result.IdentityType = identityType;

            //Console.WriteLine("Input cifNo(Enter get random)：");
            //var cifNo = Console.ReadLine();
            var cifNo = string.Empty;
            string tempdata = File.ReadAllText(individualPath);
            var individualData = JsonConvert.DeserializeObject<List<Individual>>(tempdata);
            tempdata = File.ReadAllText(corporatelPath);
            var CorporateData = JsonConvert.DeserializeObject<List<Corporate>>(tempdata);

            var canUsedI = individualData.Where(x => x.IsUsed == false).ToList();
            var canUsedC = CorporateData.Where(x => x.IsUsed == false).ToList();


            int index;
            if (identityType == "C")
            {
                index = random.Next(canUsedC.Count);
                CorporateData[index].IsUsed = true;
                cifNo = CorporateData[index].CifNo;
                result.IdentificationType = CorporateData[index].IdentificationTypeId;
                result.IdNo = CorporateData[index].IdentityNo;
                result.CustomerIndivisual= new CustomerIndivisual();
                result.CustomerCorporate = new CustomerCorporate()
                {

                };
            }
            else
            {
                index = random.Next(canUsedI.Count);
                individualData[index].IsUsed = true;
                cifNo = individualData[index].CifNo;
                result.IdentificationType = individualData[index].IdentificationTypeId;
                result.IdNo = individualData[index].IdentityNo;
                result.CustomerCorporate = new CustomerCorporate();
                result.CustomerIndivisual = new CustomerIndivisual()
                {
                    MobilePhone2 = "0927345987",
                    Telephone = "0288885555",
                    Email = "INHOTEODORE@YAHOO.COM",
                    WorkAddressLevel1 = "SGR",
                    WorkAddressLevel2 = "10",
                    WorkAddressLevel3 = "",
                    WorkAddressLevel4 = "addr",
                    WorkAddress = "B-03-09 APT SERI JATI , PUSAT BANDAR PUCHONG",
                    WorkPhone = "",
                    WorkFaxNo = "",
                    EmployerName = "DAMRON ENTERPRISE (AVOLOVER CAFE)",
                    Occupation = "A01",
                    CivilServant = "",
                    Position = "",
                    LengthOfEmployment = 1,
                    MonthlyIncome = 3500,
                    WorkingInSingapore = false,
                };
            }


            //if (string.IsNullOrEmpty(cifNo) && identityType == "I")
            //{
            //    switch (env)
            //    {
            //        case 2:
            //        case 4: cifNo = "I000000179603"; break;
            //        case 1:
            //        case 3: cifNo = "I000000000855"; break;
            //        default: cifNo = "I000000179603"; break;
            //    }
            //}

            //if (string.IsNullOrEmpty(cifNo) && identityType == "C")
            //{
            //    switch (env)
            //    {
            //        case 2:
            //        case 4: cifNo = "C000000001890"; break;
            //        case 1:
            //        case 3: cifNo = "C000000000007"; break;
            //        default: cifNo = "C000000001890"; break;
            //    }
            //}

            result.CifNo = cifNo;
            //找對應的CIFNo給值
            //switch (cifNo)
            //{
            //    case "I000000179603":
            //        result.IdentificationType = "1";
            //        result.IdNo = "851118146087"; break;
            //    case "C000000001890":
            //        result.IdentificationType = "1";
            //        result.IdNo = "000012232T"; break;
            //    case "I000000000855":
            //        result.IdentificationType = "5";
            //        result.IdNo = "0323672089"; break;
            //    case "C000000000007":
            //        result.IdentificationType = "5";
            //        result.IdNo = "009370642000"; break;
            //    default:
            //        result.IdentificationType = "1";
            //        result.IdNo = "851118146087"; break;
            //}
            //result.IdentificationType = "1";
            //result.IdNo = "851118146087";

            result.FirstName = new string(Enumerable.Repeat(charsEnglish, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            result.LastName = "";
            result.DealerCode = "MSGRMS01";
            result.DealerName = new string(Enumerable.Repeat(charsEnglish, 10)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            result.AgentCode = "MPHG0007";
            result.AgentName = "";

            //Console.WriteLine("Input CompanyId：");
            //var compId = Console.ReadLine();
            //result.CompanyId = string.IsNullOrEmpty(compId) ? 93 : Int32.Parse(compId);
            switch (env)
            {
                case 2:
                case 4: result.CompanyId = 92; break;
                case 1:
                case 3: result.CompanyId = 93; break;
                default: result.CompanyId = 92; break;
            }

            Console.WriteLine("Input productCode(or Enter get Default：L-011-0000)：");
            var productCode = Console.ReadLine();
            result.ProductCode = string.IsNullOrEmpty(productCode) ? "L-011-0000" : productCode;

            result.ProductName = "PC-Portfolio project";

            Console.WriteLine("Input productVersion(or Enter get Default：9)：");
            var version = Console.ReadLine();
            result.Version = string.IsNullOrEmpty(version) ? 9 : Int32.Parse(version);

            result.QuotesType = "ETP";
            result.Currency = "MYR";
            result.TenureMonth = 60;
            result.PaymentFrequency = "1";
            result.PaymentTiming = "PT1";//End of Period
            result.PaymentDueatMonthEnd = false;
            result.SubmissionApplicantId= "MY00213";
            result.DeptId = "20617";
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
            result.AutolifeSumIssured = 29000;

            Console.WriteLine("Input refinancing case?(or Enter get Default：N)：");
            var refinancing = Console.ReadLine();
            result.Refinancing = !string.IsNullOrEmpty(refinancing);
            if (result.Refinancing.Value)
            {
                result.SettlementContract = refinancing;
            }

            Advance advance = new Advance()
            {
                DealerRetention =3000,
                DisburseMonth = 3,
            };

            result.AdvancePayments = advance;

            //result.DealerRetention = 3000;
            
            //result.DisburseMonth = 3;
            
            //result.ApprovalTotalAmount = 10000;
            //result.ProfitInterestInvoiceAmount = 100;
            
            //result.ProfitInterestInvoiceTax = 10;
            
            result.CreditOfficer = "PH0001";
            result.CreditOfficerDept = "20617";

            Console.WriteLine("Input AutoDebitReferenceNo?(or Enter get Default：null)：");
            var autoDebitReferenceNo = Console.ReadLine();
            result.AutoDebitReferenceNo = String.IsNullOrEmpty(autoDebitReferenceNo) ? null : autoDebitReferenceNo;

            List<GuarantorPersonIndividualVM> guarantorsI = new List<GuarantorPersonIndividualVM>();
            int IndividualIndexG = random.Next(canUsedI.Count);
            individualData[IndividualIndexG].IsUsed = true;
            guarantorsI.Add(new GuarantorPersonIndividualVM()
            {
                //IdentityType = "I",
                CifNo = individualData[IndividualIndexG].CifNo,
                IdNo = individualData[IndividualIndexG].IdentityNo,
                IdentificationType = individualData[IndividualIndexG].IdentificationTypeId,
                FirstName = "DUNGCA, RAYMOND FERNANDEZ",
                LegalPosition = "Guarantor",
                
                //Relationship = "Registered",
                MobilePhone1 = "09397657185",
                //Remark = "A guarantor is someone who agrees to be responsible for your rent and your other legal obligations in a tenancy agreement"
            });
            result.GuarantorPersonIndividual = guarantorsI;

            List<GuarantorPersonCorporateVM> guarantorsC = new List<GuarantorPersonCorporateVM>();
            int CorporateIndexG = random.Next(canUsedI.Count);
            CorporateData[CorporateIndexG].IsUsed = true;
            guarantorsC.Add(new GuarantorPersonCorporateVM()
            {
                //IdentityType = "C",
                CifNo = CorporateData[CorporateIndexG].CifNo,
                IdNo = CorporateData[CorporateIndexG].IdentityNo,
                IdentificationType = CorporateData[CorporateIndexG].IdentificationTypeId,
                //custemoName
                CustomerName = "CHEAPOLAND TRANSERVICE MGMT. CORP",
                LegalPosition = "Guarantor",
                Relation = "Parents",
                MobilePhone1 = "09178277782",
            });
            result.GuarantorPersonCorporate = guarantorsC;


            //處理vcif 資料
            File.Delete(individualPath);
            File.Delete(corporatelPath);

            File.WriteAllText(individualPath, JsonConvert.SerializeObject(individualData));
            File.WriteAllText(corporatelPath, JsonConvert.SerializeObject(CorporateData));


            List<ContactPersons> contactPersons = new List<ContactPersons>();
            contactPersons.Add(new ContactPersons()
            {
                FirstName = "KWOKSON",
                LastName = "PABLO",
                Relationship = "Parents",
                MobilePhone1 = "8797616324",
            });
            contactPersons.Add(new ContactPersons()
            {
                FirstName = "NUR EL",
                LastName = "SANPABLO",
                Relationship = "Spouse",
                MobilePhone1 = "9746156189",
            });
            result.ContactPersons = contactPersons;

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
            result.Fees = fees;

            List<InSurances> insurances = new List<InSurances>();
            insurances.Add(new InSurances()
            {
                InsuranceType = "AUTOLIFE",
                ChargedPremium = 200,
                ActualPremium = 200,
                Finance = true,
                Deduct = true,
            });
            insurances.Add(new InSurances()
            {
                InsuranceType = "Car Insurance",
                ChargedPremium = 100,
                ActualPremium = 100,
                Finance = true,
                Deduct = true,
            });
            result.Insurances = insurances;

            List<Incentives> incentives = new List<Incentives>();
            incentives.Add(new Incentives()
            {
                IncentiveType = "SI",
                Rate = 0,
                ProveofReceipt = "N",
                //ProveofReceipt = false,
                ReceiptType = "Individual",
                Ewt = null,
                Amount = 200,
                AmountIncludeTax = 0
            });
            incentives.Add(new Incentives()
            {
                IncentiveType = "DI",
                Rate = 0,
                ProveofReceipt = "Y",
                //ProveofReceipt = true,
                ReceiptType = "Corporate",
                Ewt = null,
                Amount = 500,
                AmountIncludeTax = 0
            });
            result.Incentives = incentives;

            List<PaymentSchedule> schedules = new List<PaymentSchedule>();
            var payDate = DateTime.Now.Date;
            for (int i = 1; i < 61; i++)
            {
                schedules.Add(new PaymentSchedule()
                {
                    Term = i,
                    PayDate = payDate,
                    MonthlyPaymentExcludeInsurance = 725,
                    MonthlyPayment = 725
                });
                payDate.AddMonths(1);
            }
            result.PaymentSchedule = schedules;

            Console.WriteLine("Need Vchicle Collateral ? Y/N (or Enter get Default null)：");
            var vehicle = Console.ReadLine();
            bool needVehicle = string.IsNullOrEmpty(vehicle) ? false : vehicle == "Y";
            var vehicleDatas = new List<SecurityAssetVehicles>();
            var vehicleSubSeqId = new Random().Next(99997);
            if (needVehicle)
            {
                Console.WriteLine(" Y(有單)/N(無擔) (or Enter get Default N)：");
                var colleteralForAply = Console.ReadLine();
                Console.WriteLine(" 保險是否委外購買Y/N (or Enter get Default N)：");
                var insuranceType = Console.ReadLine();
                vehicleDatas.Add(new SecurityAssetVehicles()
                {
                    SubSeqId = vehicleSubSeqId,
                    AssetProperty = "s",
                    AssetType = "V",
                    AssetCategory = "motor",
                    HasCollateralValue = colleteralForAply == "Y" ? true:false,
                    Purpose = "MAP01",
                    Brand = "BR4",
                    Model = "MD60",
                    VehicleType = "VT10",
                    Transaction = "TS1",
                    DateManufacture = DateTimeOffset.Now.AddYears(-2),
                    //age = 2,
                    Cap = 5,
                    ManufacturerNationality = "EU",
                    Displacement = 0,
                    Transmission = "TM2",
                    Gasoline = "GL1",
                    VehicleColor = "Black",
                    Seats = 5,
                    Ton = 2,
                    PlateNo = "BJJ-5555",
                    PurchasePrice = 350000,
                    SalesAppraisalPrice = 40000,
                    Insurance = String.IsNullOrWhiteSpace(insuranceType) ? "N" : insuranceType,
                    RegistrationType = "Chattel Mortgage",
                    SecurityAssetVehicleFee = new List<SecurityAssetVehicleFee>(),
                });
            }
            result.SecurityAssetVehicles = vehicleDatas;

            Console.WriteLine("Need Movable Collateral ? Y/N (or Enter get Default null)：");
            var movable = Console.ReadLine();
            bool needMovable = string.IsNullOrEmpty(movable) ? false : movable == "Y";
            var movableDatas = new List<SecurityAssetMovables>();
            var movableSubSeqId = vehicleSubSeqId + 1;
            if (needMovable)
            {
                Console.WriteLine(" Y(有單)/N(無擔) (or Enter get Default N)：");
                var colleteralForAply = Console.ReadLine();
                movableDatas.Add(new SecurityAssetMovables()
                {
                    SubSeqId = movableSubSeqId,
                    AssetProperty = "f",
                    AssetType = "M",
                    AssetCategory = "heavyMotor",
                    HasCollateralValue = colleteralForAply == "Y" ? true : false,
                    Purpose = "MAP03",
                    AssetName = "Mitsubishi Dozer",
                    Brand = "BR31",
                    Model = "MD511",
                    ManufactureYear = 2000,
                    CountryOfOrigin = "JPN",
                    UnitPrice = 550000,
                    MarketPrice = 490000,
                    SecurityAssetMovablesFees = new List<SecurityAssetMovablesFee>()
                });
            }
            result.SecurityAssetMovables = movableDatas;

            Console.WriteLine("Need RealEstate Collateral ? Y/N (or Enter get Default null)：");
            var realEstate = Console.ReadLine();
            bool needRealEstate = string.IsNullOrEmpty(realEstate) ? false : realEstate == "Y";
            var realEstateDatas = new List<SecurityAssetRealEstates>();
            var realEstateSubSeqId = movableSubSeqId + 1;
            if (needMovable)
            {
                Console.WriteLine(" Y(有單)/N(無擔) (or Enter get Default N)：");
                var colleteralForAply = Console.ReadLine();
                realEstateDatas.Add(new SecurityAssetRealEstates()
                {
                    SubSeqId = movableSubSeqId,
                    AssetProperty = "f",
                    AssetType = "R",
                    AssetCategory = "STD",
                    HasCollateralValue = colleteralForAply == "Y" ? true : false,
                    Purpose = "MAP03",
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
            result.SecurityAssetRealEstates = realEstateDatas;




            if (string.IsNullOrEmpty(caseNo))
                caseNo = string.Format("TEST{0}{1}",
                    DateTime.Now.ToString("yyyyMMdd"),
                    (new Random().Next(0, 100)).ToString().PadLeft(3, '0'));
            //result.CaseNo = caseNo;


            string casePath = $@".{Path.DirectorySeparatorChar}{caseNo}{Path.DirectorySeparatorChar}";
            if (!Directory.Exists(casePath))
            {
                System.IO.FileInfo file = new System.IO.FileInfo(casePath);
                file.Directory.Create();
            }
            string creditPath = casePath + caseNo + ".json";
            var CreditResp = new GetCreditResult()
            {
                Data = result,
            };
            using (StreamWriter sw = File.CreateText(creditPath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(CreditResp, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            }


            Console.WriteLine("=======================Credit Data Start=============================");
            Console.WriteLine("=======================CaseNo：" + caseNo + "=============================");
            Console.WriteLine("=======================Path：\\commencement\\credit=============================");
            Console.WriteLine();
            Console.WriteLine(JsonConvert.SerializeObject(result, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));

            Console.WriteLine("=======================Credit Data End=============================");
            Console.WriteLine();

            //保險
            var insuranceResult = new InsurceFeeViewModel();
            insuranceResult.CompanyId = result.CompanyId;
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

            //string insuranceCollateralPath = @".\Insurce\Collateral\";
            //if (!Directory.Exists(insuranceCollateralPath))
            //{
            //    System.IO.FileInfo file2 = new System.IO.FileInfo(insuranceCollateralPath);
            //    file2.Directory.Create();
            //}
            string insuranceCollateralPath = casePath + "Collateral_" + caseNo + ".json";
            using (StreamWriter sw = File.CreateText(insuranceCollateralPath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(insuranceResult, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            }

            Console.WriteLine("=======================Insurance Data Start=============================");
            Console.WriteLine("=======================FileName：Collateral_" + caseNo + "=============================");
            Console.WriteLine("=======================Path：\\Insurce\\Collateral=============================");
            Console.WriteLine();
            Console.WriteLine(JsonConvert.SerializeObject(insuranceResult, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));

            Console.WriteLine("=======================Insurance Data End=============================");
            Console.WriteLine();

            //還款
            var repaymentInsuranceResult = new RepaymentInsurceFee();
            repaymentInsuranceResult.CompanyId = result.CompanyId;
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

            //string insuranceRepaymentPath = @".\Insurce\Repayment\";
            //if (!Directory.Exists(insuranceRepaymentPath))
            //{
            //    System.IO.FileInfo file3 = new System.IO.FileInfo(insuranceRepaymentPath);
            //    file3.Directory.Create();
            //}
            string insuranceRepaymentPath = casePath + "RepaymentInsurce_" + caseNo + ".json";
            using (StreamWriter sw = File.CreateText(insuranceRepaymentPath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(repaymentInsuranceResult, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            }
            Console.WriteLine("=======================RepaymentInsurce Data Start=============================");
            Console.WriteLine("=======================FileName：RepaymentInsurce_" + caseNo + "=============================");
            Console.WriteLine();
            Console.WriteLine(JsonConvert.SerializeObject(repaymentInsuranceResult, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));

            Console.WriteLine("=======================Insurance Data End=============================");
            Console.WriteLine();

            ////T&C 暫收款，先pending
            //var TACtempBalanceClientReq = new WriteOffReq()
            //{
            //    CompanyId = result.CompanyId,
            //    CurrencyName = result.Currency,
            //    CustNo = result.IdNo,
            //    CifNo = result.CifNo,
            //    SourceType = 1,
            //};
            //var TACtempBalanceClientResp = new WriteOffRsult();

            //var TACtempBalanceDealerReq = new WriteOffReq();
            //var TACtempBalanceDealerResp = new WriteOffRsult();

            //string TACtempBalanceClientPath = casePath + "writeOff_client" + caseNo + ".json";
            //using (StreamWriter sw = File.CreateText(TACtempBalanceClientPath))
            //{
            //    sw.WriteLine(JsonConvert.SerializeObject(TACtempBalanceClientReq, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            //}
            //Console.WriteLine("=======================writeOff Data Start=============================");
            //Console.WriteLine("=======================FileName：writeOff_client" + caseNo + "=============================");
            //Console.WriteLine();
            //Console.WriteLine(JsonConvert.SerializeObject(TACtempBalanceClientReq, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));

            //Console.WriteLine("=======================Insurance Data End=============================");
            //Console.WriteLine();

            //Credit Assign for Amending
            var assignInit = new AmendingAssignInital
            {
                CaseNo = caseNo,
                IsInitial = true,
            };
            var assignReq1 = new AmendingAssignReq
            {
                CaseNo = caseNo,
                IsInitial = false,
                CreditAuditId = 102,
                UserNo = "MY00032",
                StageId = "3",
                RoleId = 10,
            };
            var assignReq2 = new AmendingAssignReq
            {
                CaseNo = caseNo,
                IsInitial = false,
                CreditAuditId = 102,
                UserNo = "MY00190",
                StageId = "3",
                RoleId = 11,
            };
            var assignReq3 = new AmendingAssignReq
            {
                CaseNo = caseNo,
                IsInitial = false,
                CreditAuditId = 102,
                UserNo = "04063",
                StageId = "3",
                RoleId = 12,
            };
            string assignPath = casePath + "AmendingAssign_" + caseNo + "_Inital" + ".json";
            string assignPath1 = casePath + "AmendingAssign_" + caseNo + "_Req1" + ".json";
            string assignPath2 = casePath + "AmendingAssign_" + caseNo + "_Req2" + ".json";
            string assignPath3 = casePath + "AmendingAssign_" + caseNo + "_Req3" + ".json";
            using (StreamWriter sw = File.CreateText(assignPath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(assignInit, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            }
            using (StreamWriter sw = File.CreateText(assignPath1))
            {
                sw.WriteLine(JsonConvert.SerializeObject(assignReq1, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            }
            using (StreamWriter sw = File.CreateText(assignPath2))
            {
                sw.WriteLine(JsonConvert.SerializeObject(assignReq2, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            }
            using (StreamWriter sw = File.CreateText(assignPath3))
            {
                sw.WriteLine(JsonConvert.SerializeObject(assignReq3, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));
            }

            //api-setting
            var apiResult = new List<ApiSetting>();
            var quiry = new Dictionary<string, string>();
            quiry.Add("caseNo", caseNo);
            var caseAPIResult = new ApiSetting()
            {
                request = new RequestBody()
                {
                    uri = "/Credit/GetCreditRatingResult",
                    method = "GET",
                    queries = quiry
                },
                response = new ResponseBody()
                {
                    file = new FileBody()
                    {
                        name = $"configs/CommencementCase/{caseNo}/{caseNo}.json"
                    }
                }
            };
            apiResult.Add(caseAPIResult);
            var insuranceAPIResult = new ApiSetting()
            {
                request = new RequestBody()
                {
                    uri = $"/Company/{result.CompanyId}/CaseNo/{caseNo}/InsuranceFee",
                    method = "POST"
                },
                response = new ResponseBody()
                {
                    file = new FileBody()
                    {
                        name = $"configs/CommencementCase/{caseNo}/Collateral_{caseNo}.json"
                    }
                }
            };
            apiResult.Add(insuranceAPIResult);
            var repaymentAPIResult = new ApiSetting()
            {
                request = new RequestBody()
                {
                    uri = $"/Company/{result.CompanyId}/CaseNo/{caseNo}/RepaymentInsuranceFee",
                    method = "POST"
                },
                response = new ResponseBody()
                {
                    file = new FileBody()
                    {
                        name = $"configs/CommencementCase/{caseNo}/RepaymentInsurce_{caseNo}.json"
                    }
                }
            };
            apiResult.Add(repaymentAPIResult);

            var AssignResultInit = new ApiSetting()
            {
                request = new RequestBody()
                {
                    uri = $"/Credit/GetAmendingAssignUser",
                    method = "POST",
                    file = new RequestFileBody()
                    {
                        json = $"configs/CommencementCase/{caseNo}/AmendingAssign_{caseNo}_Inital.json",
                    }
                },
                response = new ResponseBody()
                {
                    file = new FileBody()
                    {
                        name = $"configs/commencement/credit-bpm/GetAmendingAssignUser_Resp1.json"
                    }
                }
            };
            apiResult.Add(AssignResultInit);

            for (int i = 1; i < 4; i++)
            {
                var AssignResult = new ApiSetting()
                {
                    request = new RequestBody()
                    {
                        uri = $"/Credit/GetAmendingAssignUser",
                        method = "POST",
                        file = new RequestFileBody()
                        {
                            json = $"configs/CommencementCase/{caseNo}/AmendingAssign_{caseNo}_Req{i}.json",
                        }
                    },
                    response = new ResponseBody()
                    {
                        file = new FileBody()
                        {
                            name = $"configs/commencement/credit-bpm/GetAmendingAssignUser_Resp{i+1}.json"
                        }
                    }
                };
                apiResult.Add(AssignResult);
            }

            string apiSettingPath = casePath + "api-setting.json";
            using (StreamWriter sw = File.CreateText(apiSettingPath))
            {
                sw.WriteLine(JsonConvert.SerializeObject(apiResult, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Include }));
            }


            Console.WriteLine("=======================Repayment Insurance Data Start============================");
            Console.WriteLine("======================= FileName：   RepaymentInsurce_" + caseNo + "==================");
            Console.WriteLine("======================= Path：   \\Insurce\\Repayment=============================");
            Console.WriteLine();
            Console.WriteLine(JsonConvert.SerializeObject(repaymentInsuranceResult, new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() { NamingStrategy = new CamelCaseNamingStrategy() }, NullValueHandling = NullValueHandling.Include, DefaultValueHandling = DefaultValueHandling.Include }));

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
            Console.WriteLine();
            Console.WriteLine("moco-global-setting：");
            Console.WriteLine($"configs/CommencementCase/{caseNo}/api-setting.json");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.ReadLine();
        }
    }
}
