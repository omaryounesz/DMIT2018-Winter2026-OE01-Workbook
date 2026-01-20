<Query Kind="Statements">
  <Connection>
    <ID>4bf2834f-aa21-4f28-9aed-abb50fe48a89</ID>
    <NamingServiceVersion>3</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <UseMicrosoftDataSqlClient>true</UseMicrosoftDataSqlClient>
    <EncryptTraffic>true</EncryptTraffic>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Chinook-2025</Database>
    <MapXmlToString>false</MapXmlToString>
    <DriverData>
      <SkipCertificateCheck>true</SkipCertificateCheck>
    </DriverData>
  </Connection>
</Query>

int[] numbers =  {1, 2, 3, 4, 5};
//modulus = %
numbers.Where(x => x % 2== 0).Dump();

Albums
	.Where(x => x.ReleaseYear >= 1980)
	.Select(x => x.Title)