<Query Kind="Statements">
  <Connection>
    <ID>a0a69834-bd9d-49b8-bc93-c77f155e83fc</ID>
    <NamingServiceVersion>3</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <UseMicrosoftDataSqlClient>true</UseMicrosoftDataSqlClient>
    <EncryptTraffic>true</EncryptTraffic>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Contoso</Database>
    <MapXmlToString>false</MapXmlToString>
    <DriverData>
      <SkipCertificateCheck>true</SkipCertificateCheck>
    </DriverData>
  </Connection>
</Query>

//Question 1
Employees
	.Where(x => x.HireDate > new DateOnly(2022, 1, 1))
	.Select(x => x)
	.Dump();


//Question 2: Multiple Where Clause, All Fields
//Context: "Our inventory team wants to find all products that have been available for sale
//since July 1, 2019, to ensure they are properly stocked."
//Question: "How would you filter the Product table to retrieve these products?"
//Products
//    .Where(x => x.AvailableForSaleDate.HasValue)
//    .Select(x => x)
//    .Where(x => x.AvailableForSaleDate >= new DateTime(2019, 7, 1))
//    .Dump();

var products = Products
	.Where(x => x.AvailableForSaleDate.HasValue)
	.Select(x => x);

//var products = Products
//    .Where(x => x.AvailableForSaleDate != null)
//    .Select(x => x);

products
	.Where(x => x.AvailableForSaleDate >= (new DateTime(2019, 7, 1)))
	.Select(x => x)
	.Dump();

Products
	.Where(x => x.AvailableForSaleDate == null)
	.Dump();


//Question 3: Multiple Where Clauses
//Context: "To update our customer database, we need to pull the email addresses of
//all customers with a yearly income between $60,000 & $61,000."
//Question: "How would you filter the Customer table and retrieve only the email addresses
//of these customers?"
Customers
	.Where(x => x.YearlyIncome >= 60000 && x.YearlyIncome <= 61000)
	.Select(x => x.EmailAddress)
	.Dump();


//Validation from the above
//Customers
//    .Where(x => x.YearlyIncome >= 60000 && x.YearlyIncome <= 61000)
//    .Select(x => new
//    {
//        EmailAdd = x.EmailAddress,
//        YearlyIncome = x.YearlyIncome
//    })
//    .OrderBy(x => x.YearlyIncome)
//    .Dump();


//Question 4: Filtering using Contain
//Context: "The marketing department needs a list of all promotions focused on
//North America to prepare for the upcoming sale."
//Question: "How would you filter the Promotion table to retrieve the promotion information"

Promotions
	.Where(x => x.PromotionName.ToUpper().Contains("NORTH AMERICA"))
	.Select(x => x)
	.Dump();


Promotions
	.Where(x => x.PromotionName.ToLower().Contains("north america"))
	.Select(x => x)
	.Dump();