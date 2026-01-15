<Query Kind="Program">
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

void Main()
{
	int paramYear = 2000;
	GetAllAlbumByReleaseYear(paramYear).Dump();
}

// You can define other methods, fields, classes and namespaces here
List<Album> GetAllAlbumByReleaseYear(int paramYear)
{
	return Albums
		.Where(x => x.ReleaseYear == paramYear)
		.Select(x => x)
		.ToList();
}
