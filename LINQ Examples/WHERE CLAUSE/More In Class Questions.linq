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

//Take-Home Practice (4 Questions) - WHERE Clauses


//Question 1: Single Where Clause, All Fields
//Context: "We need to review all invoices created after November 2023 to ensure they were processed correctly."
//Question: "How would you filter the Invoice table to retrieve these invoices?"
Invoices
	.Where(x => x.DateKey > new DateTime(2023, 11, 30))
	.Select(x => x)
	.Dump();


//Question 2: Single Where Clause, All Fields
//Context: "Our regional analysis team needs to focus on all sales territories located in Canada for a new market expansion project."
//Question: "How would you filter the Geography table to retrieve all records where the country is Canada?"
Geographies
	.Where(x => x.RegionCountryName.ToUpper().Contains("Canada"))
	.Select(x => x)
	.Dump();


//Question 3: Multiple Where Clauses, All Fields
//Context: "After reviewing the previous data output, we noticed records with GeographyType labeled as 'Country/Region.' For our detailed analysis,
//we only want to focus on cities located in Ontario, Canada."
//Question: "How would you filter the Geography table to retrieve records where the Type is 'City' and the Province Name is 'Ontario'?"
Geographies
	.Where(x => x.GeographyType == "City")
	.Where(x => x.StateProvinceName == "Ontario")
	.Select(x => x)
	.Dump();


//Question 4: Filtering using Contain
//Context: "There has been some confusion with store names that include the term 'No.' in them, which might indicate store numbers or branches.
//We need to identify all stores with 'No.' in their names to review their details and address any inconsistencies."
//Question: "How would you filter the Store table to retrieve all records where the StoreName contains 'No.'?"
Stores
	.Where(x => x.StoreName.Contains("No."))
	.Select(x => x)
	.Dump();
