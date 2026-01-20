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

//Question 1: Single Where Clause, Ordered by Last name
//Context: "We need to identify all employees hired after January 1, 2022,
//to ensure they are included in our new training program."
//Question: "How would you filter the Employee table to retrieve these employees,
//ordered by last name?"

Employees
	.Where(x => x.HireDate.HasValue && x.HireDate.Value > new DateOnly(2022, 1, 1))
	.OrderBy(x => x.LastName)
	.Select(x => x)
	.Dump();


// Question 2 N/A



//Question 3: Multiple Where Clauses, Ordered by Email Address
//Context: "To update our customer database, we need to pull the email addresses of
//all customers with a yearly income between $60,000 & $61,000."
//NOTE: Order by must follow the where clause but before the select.
//Question: "How would you filter the Customer table and retrieve only
//the email addresses of these customers, ordered by email address?"


Customers
	.Where(x => x.YearlyIncome >= 60000 && x.YearlyIncome <= 61000)
	.OrderBy(x => x.EmailAddress)
	.Select(x => x.EmailAddress)
	.Dump();

//Question 4: Filtering using Contains, Ordered by Promotion Name and Start Date
//Context: "The marketing department needs a list of all promotions focused on North America
//to prepare for the upcoming sale."
//Question: "How would you filter the Promotion table to retrieve the promotion information
//ordered by promotion name?"

Promotions
	.Where(x => x.PromotionName.Contains("North America"))
	.OrderBy(x => x.PromotionName)
	.ThenBy(x => x.StartDate)
	.Select(x => x)
	.Dump();