string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    displayEmails(corporate[i, 0], corporate[i,1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    displayEmails(external[i, 0], external[i, 1], externalDomain);
}

void displayEmails(string first, string last, string domain = "contoso.com")
{
    string emailName = (first.Substring(0,2) + last).ToLower();
    Console.WriteLine($"{emailName}@{domain}");
    return;
}

// expected output:
// robavin@contoso.com
// sibright@contoso.com
// kisinclair@contoso.com
// aakamath@contoso.com
// sadelucchi@contoso.com
// siali@contoso.com
// viashton@hayworth.com
// codysart@hayworth.com
// shlawrence@hayworth.com
// davaldes@hayworth.com
