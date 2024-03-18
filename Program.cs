// See https://aka.ms/new-console-template for more information



using Microsoft.VisualBasic;
using Newtonsoft.Json;
using NexusAPIWrapper;

NexusAPI_processes processes = new NexusAPI_processes("live");
var api = processes.api;
#region Main

#region Welcome/Menu

//int numberOfOptions = 4;
string menuUserInputString = "99";
int menuUserInput;
bool isInt = int.TryParse(menuUserInputString, out menuUserInput);


Console.WriteLine("Velkommen");
//While the user inputs other values than the options given, we present the menu to the user
while (menuUserInput != 0)
{
    Console.Clear();
    Console.WriteLine(@"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
    Console.WriteLine(@"||                             __     __    __             _____     _____   __     _____  ||");
    Console.WriteLine(@"|| \      / |  | /     /\     |  \   |  \  |  \   |    |  /     \   |       |  \   |       ||");
    Console.WriteLine(@"||  \    /  |  |/     /  \    |__/   |__/  |__/   |    |  |    __   |--     |__/   |--     ||");
    Console.WriteLine(@"||   \  /   |  |\    /----\   |  \   |  \  |  \   |    |  |   /  |  |       |  \   |       ||");
    Console.WriteLine(@"||    \/    |  | \  /      \  |   \  |__/  |   \   \__/   \_____/   |_____  |   \  |_____  ||");
    Console.WriteLine(@"||                                                                                         ||");
    Console.WriteLine(@"|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
    Console.WriteLine(@"");
    Console.WriteLine("         Vælg fra menuen.");
    //Console.WriteLine("         1. Aktiver alle vikarbrugere.");
    Console.WriteLine("         2. Fremsøg vikarbruger der ønskes aktiveret/deaktiveret.");
    Console.WriteLine("         3. Aktiver vikarbruger med kendte initialer.");
    //Console.WriteLine("3. Aktiver vikarbruger med kendt Id.");
    //Console.WriteLine("4. Deaktiver vikarbruger med kendt Id.");
    Console.WriteLine("         0. Afslut");
    Console.WriteLine();
    menuUserInputString = Console.ReadLine();
    isInt = int.TryParse(menuUserInputString, out menuUserInput);
    //while (menuUserInput > 0 && menuUserInput < numberOfOptions + 1)
    //{
        switch (menuUserInput)
        {
        case 0:
            //Exits the program
            System.Environment.Exit(0);
            break;
        case 1:
            #region Menu option 1
        //    Console.WriteLine("Bekræft aktivering af alle vikarbrugere J/N (Ja/Nej)");
        //    var menuChoice = Console.ReadKey();

        //    switch (menuChoice.Key)
        //    {
        //        case ConsoleKey.J:
        //            Console.WriteLine("");
        //            Console.WriteLine("Aktiverer alle vikarbrugere...");
        //            Console.WriteLine("Det tager op mod 5 min. Vent venligst.");
        //            processes.ActivateInactiveSubstituteProfessionals();

        //            var prosActivated = processes.professionalsList;


        //            ///////////////////
        //            ///Test////////////
        //            ///////////////////

        //            //deactivating users, so they can be testet again
        //            //foreach (var pro in prosActivated)
        //            //{
        //            //    processes.DeactivateProfessional(pro.Id);
        //            //}

        //            ///////////////////
        //            ///Test end////////
        //            ///////////////////



        //            Console.WriteLine("Følgende vikarbrugere er blevet aktiveret:");
        //            foreach (var item in prosActivated)
        //            {
        //                Console.WriteLine(item.Initials);
        //            }

        //            Console.WriteLine("Tryk på en tast...");
        //            Console.ReadLine();
        //            break;
                
        //        default:
        //            menuUserInput = 99;
        //            break;
        //    }
        //    menuUserInput = 99;
            
        //    break;
            #endregion Menu option 1
        case 2:
            #region Menu option 2

            ActivateOrDeactivateProBasedOnSearch();
            #region inline code
            //Console.WriteLine("Indtast et navn du gerne vil søge efter:");
            //string userInputSearchString = Console.ReadLine();
            //var professionals = api.GetProfessionals(userInputSearchString);

            ////Getting only vik users
            //List<Professional_Root> vikProfessionals = new List<Professional_Root>();
            //foreach (var prof in professionals)
            //{
            //    Professional_Root proObject = JsonConvert.DeserializeObject<Professional_Root>(prof.Value.ToString());
            //    if (proObject.Initials.Contains("vik"))
            //    {
            //        vikProfessionals.Add(proObject);
            //    }
            //}


            //int professionalsCount = vikProfessionals.Count;
            //string personsFoundText;

            //switch (professionalsCount)
            //{
            //    case 1:
            //        personsFoundText = "person";
            //        break;
            //    default:
            //        personsFoundText = "personer";
            //        break;
            //}

            //Console.Clear();
            //Console.WriteLine("Der blev fundet " + professionalsCount + " " + personsFoundText + " med navnet " + userInputSearchString);
            //Console.WriteLine();

            //if (professionalsCount == 0)
            //{
            //    break;
            //    menuUserInput = 99;
            //}

            //List<int> idList = new List<int>();

            ////List all professionals in the console for the user to choose from
            //foreach (var proObject in vikProfessionals)
            //{
            //    //Professional_Root proObject = JsonConvert.DeserializeObject<Professional_Root>(pro.Value.ToString());
            //    Console.WriteLine("Fulde navn: " + proObject.FullName);
            //    Console.WriteLine("Initialer: " + proObject.Initials);
            //    Console.WriteLine("Id: " + proObject.Id);
            //    string activeString = string.Empty;
            //    if (proObject.Active == true) { activeString = "Ja"; } else { activeString = "Nej"; }
            //    Console.WriteLine("Bruger aktiv: " + activeString);
            //    idList.Add(proObject.Id);
            //    Console.WriteLine();
            //}

            //bool idFromListChosen = false;
            //string userInputString = string.Empty;
            //int menu2UserInput = 0;
            //Professional_Root chosenPro = new Professional_Root();
            ////If the user chooses an Id from the list, we can activate it, otherwise the user should choose again or terminate
            //while (!idFromListChosen)
            //{
            //    Console.WriteLine("Tast Id for den bruger du ønsker aktiveret/deaktiveret: ");
            //    Console.WriteLine("Tast 0 (nul) for at afslutte");
            //    Console.WriteLine("");
                
            //    userInputString = Console.ReadLine();
            //    isInt = false;
            //    isInt = int.TryParse(userInputString, out menu2UserInput);
            //    if (menu2UserInput == 0)
            //    {
            //        menuUserInputString = "99";
            //        break;
            //    }
            //    foreach (int id in idList)
            //    {
            //        if (menu2UserInput == id)
            //        {
            //            idFromListChosen = true;
            //            break;
            //        }
            //    }
            //}
            //if (idFromListChosen)
            //{
            //    foreach (var professional in professionals)
            //    {
            //        Professional_Root proObject = JsonConvert.DeserializeObject<Professional_Root>(professional.Value.ToString());

            //        if (proObject.Id == menu2UserInput)
            //        {
            //            chosenPro = proObject; break;
            //        }
            //    }

            //    Console.WriteLine("Du har valgt:");
            //    Console.WriteLine("Fulde navn: " + chosenPro.FullName);
            //    Console.WriteLine("Initialer: " + chosenPro.Initials);
            //    Console.WriteLine("Id: " + chosenPro.Id);

            //    Console.WriteLine("Bekræft handling på bruger");
            //    Console.WriteLine("A - Aktivering af bruger");
            //    Console.WriteLine("D - Deaktivering af bruger");
            //    var menu2Choice = Console.ReadKey();

            //    switch (menu2Choice.Key)
            //    {
            //        case ConsoleKey.A:
            //            Console.WriteLine("");
            //            Console.WriteLine("Bruger aktiveres... Vent venligst");
            //            processes.ActivateProfessional(menu2UserInput);
            //            break;
            //        case ConsoleKey.D:
            //            Console.WriteLine("");
            //            Console.WriteLine("Bruger deaktiveres... Vent venligst");
            //            processes.DeactivateProfessional(menu2UserInput);
            //            break;
            //        default:
            //            menuUserInput = 99;
            //            break;
            //    }

            //    var prof = processes.GetProfessional(menu2UserInput);
            //    var proStatus = prof.Active;

            //    if (proStatus == true)
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Brugeren " + prof.FullName + " (id: " + prof.Id + ") er aktiveret");
            //        Console.WriteLine("Tryk på en tast...");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Brugeren " + prof.FullName + " (id: " + prof.Id + ") er deaktiveret");
            //        Console.WriteLine("Tryk på en tast...");
            //        Console.ReadLine();
            //    }

            //    menuUserInput = 99;
                
            //}
            break;
        #endregion inline code

        #endregion Menu option 2
        case 3:
            #region menu option 3
            ActivateOrDeactivateProBasedOnInitialsInput();

            #region inline code
            //int menu3UserInnput;
            //string menu3ProfessionalInitialsInputString = string.Empty;
            //Console.WriteLine("Indtast Id for den du gerne vil deaktiverer - eller tast 0 (nul) for at afslutte: ");
            //menu3ProfessionalInitialsInputString = Console.ReadLine();

            //var prosFound = processes.GetProfessionals(menu3ProfessionalInitialsInputString, true);
            //int prosFoundCount = prosFound.Count;

            //var proFound = prosFound[0];

            //Console.WriteLine("Du har valgt:");
            //Console.WriteLine("Fulde navn: " + proFound.FullName);
            //Console.WriteLine("Initialer: " + proFound.Initials);
            //Console.WriteLine("Id: " + proFound.Id);

            //Console.WriteLine("Bekræft aktivering af bruger Ja/Nej (J/N)");
            //var menu3Choice = Console.ReadKey();

            //switch (menu3Choice.Key)
            //{
            //    case ConsoleKey.J:
            //        Console.WriteLine("");
            //        Console.WriteLine("Bruger aktiveres... Vent venligst");
            //        processes.ActivateProfessional(proFound.Id);
            //        break;
            //    case ConsoleKey.D:
            //        Console.WriteLine("");
            //        Console.WriteLine("Bruger deaktiveres... Vent venligst");
            //        processes.DeactivateProfessional(proFound.Id);
            //        break;
            //    default:
            //        menuUserInput = 99;
            //        break;
            //}

            //var pro = processes.GetProfessional(proFound.Id);
            //var status = pro.Active;

            //if (status == true)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Brugeren " + pro.FullName + " (id: " + pro.Id + ") er aktiveret");
            //    Console.WriteLine("Tryk på en tast...");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("Brugeren " + pro.FullName + " (id: " + pro.Id + ") er deaktiveret");
            //    Console.WriteLine("Tryk på en tast...");
            //    Console.ReadLine();
            //}

            #endregion inline code
            menuUserInput = 99;

            break;
        #endregion menu option 3
        case 99:
            #region Menu option 99
            int menu3UserInput;
            string professionalIdInputString = string.Empty;
            bool isMenu3UserInputInt;
            Console.WriteLine("Indtast Id for den du gerne vil aktiverer - eller tast 0 (nul) for at afslutte: ");
            professionalIdInputString = Console.ReadLine();
            isMenu3UserInputInt = int.TryParse(professionalIdInputString, out menu3UserInput);

            if (menu3UserInput != 0)
            {
                Professional_Root menu3ChosenPro = new Professional_Root();
                if (isMenu3UserInputInt)
                {
                    menu3ChosenPro = processes.GetProfessional(menu3UserInput);
                }

                Console.WriteLine("Du har valgt:");
                Console.WriteLine("Fulde navn: " + menu3ChosenPro.FullName);
                Console.WriteLine("Initialer: " + menu3ChosenPro.Initials);
                Console.WriteLine("Id: " + menu3ChosenPro.Id);
                

                // If the chosen user does not have "vik" in the initials then we can't activate it
                if (!menu3ChosenPro.Initials.Contains("vik"))
                {
                    Console.WriteLine("Det er ikke en vikarbruger, og kan derfor ikke aktiveres.");
                    Console.WriteLine("Tryk på en tast...");
                    Console.ReadLine();
                    menuUserInput = 99;
                    break;
                }
                

                Console.WriteLine("Bekræft aktivering af bruger J/N (Ja/Nej)");
                var choice = Console.ReadKey();

                switch (choice.Key)
                {
                    case ConsoleKey.J:
                        Console.WriteLine("");
                        Console.WriteLine("Bruger aktiveres... Vent venligst");
                        processes.ActivateProfessional(menu3UserInput);
                        break;
                    default:
                        menuUserInput = 0;
                        break;
                }
            
            
                var prof = processes.GetProfessional(menu3UserInput);
                var profStatus = prof.Active;

                if (profStatus == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Brugeren " + prof.FullName + " (id: " + prof.Id + ") er nu aktiveret");
                    Console.WriteLine("Tryk på en tast...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Der er sket en fejl, prøv igen.");
                    Console.WriteLine("Tryk på en tast...");
                    Console.ReadLine();
                }
            }
            
            menuUserInput = 99;
            break;
        #endregion Menu option 99
        case 4:
            #region Menu option 4
            DeactivateSubstituteProWithKnownId();

            #region inlineCode
            //int menu4UserInput;
            //string menu4ProfessionalIdInputString = string.Empty;
            //bool isMenu4UserInputInt;
            //Console.WriteLine("Indtast Id for den du gerne vil deaktiverer - eller tast 0 (nul) for at afslutte: ");
            //menu4ProfessionalIdInputString = Console.ReadLine();
            //isMenu4UserInputInt = int.TryParse(menu4ProfessionalIdInputString, out menu4UserInput);

            //if (menu4UserInput != 0)
            //{
            //    Professional_Root menu4ChosenPro = new Professional_Root();
            //    if (isMenu4UserInputInt)
            //    {
            //        menu4ChosenPro = processes.GetProfessional(menu4UserInput);
            //    }
            //    Console.WriteLine("Du har valgt:");
            //    Console.WriteLine("Fulde navn: " + menu4ChosenPro.FullName);
            //    Console.WriteLine("Initialer: " + menu4ChosenPro.Initials);
            //    Console.WriteLine("Id: " + menu4ChosenPro.Id);

            //    // If the chosen user does not have "vik" in the initials then we can't deactivate it
            //    if (!menu4ChosenPro.Initials.Contains("vik"))
            //    {
            //        Console.WriteLine("Det er ikke en vikarbruger, og kan derfor ikke deaktiveres.");
            //        Console.WriteLine("Tryk på en tast...");
            //        Console.ReadLine();
            //        menuUserInput = 99;
            //        break;
            //    }

            //    Console.WriteLine("Bekræft deaktivering af bruger J/N (Ja/Nej)");
            //    var menu4Choice = Console.ReadKey();

            //    switch (menu4Choice.Key)
            //    {
            //        case ConsoleKey.J:
            //            Console.WriteLine("");
            //            Console.WriteLine("Bruger deaktiveres... Vent venligst");
            //            processes.DeactivateProfessional(menu4UserInput);
            //            break;
            //        default:
            //            menuUserInput = 0;
            //            break;
            //    }


            //    var menu4Prof = processes.GetProfessional(menu4UserInput);
            //    var menu4ProfStatus = menu4Prof.Active;

            //    if (menu4ProfStatus == false)
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Brugeren " + menu4Prof.FullName + " (id: " + menu4Prof.Id + ") er nu deaktiveret");
            //        Console.WriteLine("Tryk på en tast...");
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("");
            //        Console.WriteLine("Der er sket en fejl, prøv igen.");
            //        Console.WriteLine("Tryk på en tast...");
            //        Console.ReadLine();
            //    }

            //}
            #endregion inline code
            menuUserInput = 99;
            break;
        #endregion menu 4
        case 5:
            
            break;
        default:
            Console.WriteLine("Du har valgt en forkert mulighed - prøv igen.");
            Console.WriteLine();
            Console.WriteLine("1. Aktiver alle vikarbrugere.");
            Console.WriteLine("2. Fremsøg bruger der ønskes aktiveret.");
            Console.WriteLine("3. Aktiver vikarbruger med kendt Id.");
            Console.WriteLine("4. Deaktiver vikarbruger med kendt Id.");
            Console.WriteLine("0. Afslut");

            menuUserInputString = Console.ReadLine();
            isInt = int.TryParse(menuUserInputString, out menuUserInput);
            break;
        }
    //}
}


#endregion Welcome/Menu






#endregion Main
#region options code

int DeactivateSubstituteProWithKnownId()
{
    int menuUserInput;
    string menuProfessionalIdInputString = string.Empty;
    bool ismenuUserInputInt;
    Console.WriteLine("Indtast Id for den du gerne vil deaktiverer - eller tast 0 (nul) for at afslutte: ");
    menuProfessionalIdInputString = Console.ReadLine();
    ismenuUserInputInt = int.TryParse(menuProfessionalIdInputString, out menuUserInput);

    if (menuUserInput != 0)
    {
        Professional_Root menuChosenPro = new Professional_Root();
        if (ismenuUserInputInt)
        {
            menuChosenPro = processes.GetProfessional(menuUserInput);
        }
        Console.WriteLine("Du har valgt:");
        Console.WriteLine("Fulde navn: " + menuChosenPro.FullName);
        Console.WriteLine("Initialer: " + menuChosenPro.Initials);
        Console.WriteLine("Id: " + menuChosenPro.Id);

        // If the chosen user does not have "vik" in the initials then we can't deactivate it
        if (!menuChosenPro.Initials.Contains("vik"))
        {
            Console.WriteLine("Det er ikke en vikarbruger, og kan derfor ikke deaktiveres.");
            Console.WriteLine("Tryk på en tast...");
            Console.ReadLine();
            menuUserInput = 99;
        }

        Console.WriteLine("Bekræft deaktivering af bruger J/N (Ja/Nej)");
        var menuChoice = Console.ReadKey();

        switch (menuChoice.Key)
        {
            case ConsoleKey.J:
                Console.WriteLine("");
                Console.WriteLine("Bruger deaktiveres... Vent venligst");
                processes.DeactivateProfessional(menuUserInput);
                break;
            default:
                menuUserInput = 0;
                break;
        }


        var menuProf = processes.GetProfessional(menuUserInput);
        var menuProfStatus = menuProf.Active;

        if (menuProfStatus == false)
        {
            Console.WriteLine("");
            Console.WriteLine("Brugeren " + menuProf.FullName + " (id: " + menuProf.Id + ") er nu deaktiveret");
            Console.WriteLine("Tryk på en tast...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Der er sket en fejl, prøv igen.");
            Console.WriteLine("Tryk på en tast...");
            Console.ReadLine();
        }

    }

    return 99;
}

int ActivateSubstituteProWithKnownId()
{
    int menuUserInnput;
    string menuProfessionalInitialsInputString = string.Empty;
    Console.WriteLine("Indtast Id for den du gerne vil aktiverer - eller tast 0 (nul) for at afslutte: ");
    menuProfessionalInitialsInputString = Console.ReadLine();

    var prosFound = processes.GetProfessionals(menuProfessionalInitialsInputString, true);
    int prosFoundCount = prosFound.Count;

    var proFound = prosFound[0];

    Console.WriteLine("Du har valgt:");
    Console.WriteLine("Fulde navn: " + proFound.FullName);
    Console.WriteLine("Initialer: " + proFound.Initials);
    Console.WriteLine("Id: " + proFound.Id);

    Console.WriteLine("Bekræft aktivering af bruger Ja/Nej (J/N)");
    var menuChoice = Console.ReadKey();

    switch (menuChoice.Key)
    {
        case ConsoleKey.J:
            Console.WriteLine("");
            Console.WriteLine("Bruger aktiveres... Vent venligst");
            processes.ActivateProfessional(proFound.Id);
            break;
        case ConsoleKey.D:
            Console.WriteLine("");
            Console.WriteLine("Bruger deaktiveres... Vent venligst");
            processes.DeactivateProfessional(proFound.Id);
            break;
        default:
            menuUserInput = 99;
            break;
    }

    var pro = processes.GetProfessional(proFound.Id);
    var status = pro.Active;

    if (status == true)
    {
        Console.WriteLine("");
        Console.WriteLine("Brugeren " + pro.FullName + " (id: " + pro.Id + ") er aktiveret");
        Console.WriteLine("Tryk på en tast...");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Brugeren " + pro.FullName + " (id: " + pro.Id + ") er deaktiveret");
        Console.WriteLine("Tryk på en tast...");
        Console.ReadLine();
    }
    return 99;
}

int ActivateOrDeactivateProBasedOnSearch()
{
    Console.WriteLine("Indtast et navn du gerne vil søge efter:");
    string userInputSearchString = Console.ReadLine();
    var professionals = api.GetProfessionals(userInputSearchString);

    //Getting only vik users
    List<Professional_Root> vikProfessionals = new List<Professional_Root>();
    foreach (var prof in professionals)
    {
        //Professional_Root proObject = JsonConvert.DeserializeObject<Professional_Root>(prof.ToString());
        if (prof.Initials.Contains("vik"))
        {
            vikProfessionals.Add(prof);
        }
    }


    int professionalsCount = vikProfessionals.Count;
    string personsFoundText;

    switch (professionalsCount)
    {
        case 1:
            personsFoundText = "person";
            break;
        default:
            personsFoundText = "personer";
            break;
    }

    Console.Clear();
    Console.WriteLine("Der blev fundet " + professionalsCount + " " + personsFoundText + " med navnet " + userInputSearchString);
    Console.WriteLine();

    if (professionalsCount != 0)
    {
        List<int> idList = new List<int>();
        List<string> initialsList = new List<string>();

        //List all professionals in the console for the user to choose from
        foreach (var proObject in vikProfessionals)
        {
            //Professional_Root proObject = JsonConvert.DeserializeObject<Professional_Root>(pro.Value.ToString());
            Console.WriteLine("Fulde navn: " + proObject.FullName);
            Console.WriteLine("Initialer: " + proObject.Initials);
            Console.WriteLine("Id: " + proObject.Id);
            string activeString = string.Empty;
            if (proObject.Active == true) { activeString = "Ja"; } else { activeString = "Nej"; }
            Console.WriteLine("Bruger aktiv: " + activeString);
            idList.Add(proObject.Id);
            initialsList.Add(proObject.Initials);
            Console.WriteLine();
        }

        bool idFromListChosen = false;
        bool initialFromListChosen = false;
        string userInputString = string.Empty;
        string userInitialsInputString = string.Empty;
        int menuUserInput = 999;
        Professional_Root chosenPro = new Professional_Root();
        //If the user chooses an Id from the list, we can activate it, otherwise the user should choose again or terminate
        while (!initialFromListChosen)
        {
            Console.WriteLine("Tast initialer (vikxxxx)for den bruger du ønsker aktiveret/deaktiveret: ");
            Console.WriteLine("Tast 0 (nul) for at afslutte");
            Console.WriteLine("");

            userInputString = Console.ReadLine();
            isInt = false;
            isInt = int.TryParse(userInputString, out menuUserInput);
            if (!isInt)
            {
                menuUserInput = 999;
            }
            if (menuUserInput == 0)
            {
                menuUserInput = 99;
                break;
            }
            foreach (string initial in initialsList)
            {
                if (userInputString == initial)
                {
                    initialFromListChosen = true;
                    break;
                }
            }
        }
        if (initialFromListChosen)
        {
            foreach (var professional in professionals)
            {
                //Professional_Root proObject = JsonConvert.DeserializeObject<Professional_Root>(professional.ToString());

                if (professional.Initials == userInputString)
                {
                    chosenPro = professional; break;
                }
            }

            Console.WriteLine("Du har valgt:");
            Console.WriteLine("Fulde navn: " + chosenPro.FullName);
            Console.WriteLine("Initialer: " + chosenPro.Initials);
            Console.WriteLine("Id: " + chosenPro.Id);

            Console.WriteLine("Bekræft handling på bruger");
            Console.WriteLine("A - Aktivering af bruger");
            Console.WriteLine("D - Deaktivering af bruger");
            var menuChoice = Console.ReadKey();

            switch (menuChoice.Key)
            {
                case ConsoleKey.A:
                    Console.WriteLine("");
                    Console.WriteLine("Bruger aktiveres... Vent venligst");
                    processes.ActivateProfessional(chosenPro.Id);
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("");
                    Console.WriteLine("Bruger deaktiveres... Vent venligst");
                    processes.DeactivateProfessional(chosenPro.Id);
                    break;
                default:
                    menuUserInput = 99;
                    break;
            }

            var prof = processes.GetProfessional(chosenPro.Id);
            var proStatus = prof.Active;

            if (proStatus == true)
            {
                Console.WriteLine("");
                Console.WriteLine("Brugeren " + prof.FullName + " (id: " + prof.Id + ") er aktiveret");
                Console.WriteLine("Tryk på en tast...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Brugeren " + prof.FullName + " (id: " + prof.Id + ") er deaktiveret");
                Console.WriteLine("Tryk på en tast...");
                Console.ReadLine();
            }

            

        }

    }
    return 99;
}

int ActivateOrDeactivateProBasedOnInitialsInput()
{
    Console.WriteLine("Indtast initialer (vikxxxx) du gerne vil søge efter:");
    string userInputSearchString = Console.ReadLine();
    var professionals = api.GetProfessionals(userInputSearchString);

    //Getting only vik users
    List<Professional_Root> vikProfessionals = new List<Professional_Root>();
    foreach (var prof in professionals)
    {
        //Professional_Root proObject = JsonConvert.DeserializeObject<Professional_Root>(prof.ToString());
        if (prof.Initials.Contains("vik"))
        {
            vikProfessionals.Add(prof);
        }
    }


    int professionalsCount = vikProfessionals.Count;
    string personsFoundText;

    switch (professionalsCount)
    {
        case 1:
            personsFoundText = "person";
            break;
        default:
            personsFoundText = "personer";
            break;
    }

    
    Console.Clear();
    

    if (professionalsCount != 0 && professionalsCount <2)
    {        
        List<int> idList = new List<int>();
        List<string> initialsList = new List<string>();

        //List all professionals in the console for the user to choose from
        foreach (var proObject in vikProfessionals)
        {
            //Professional_Root proObject = JsonConvert.DeserializeObject<Professional_Root>(pro.Value.ToString());
            Console.WriteLine("Fulde navn: " + proObject.FullName);
            Console.WriteLine("Initialer: " + proObject.Initials);
            Console.WriteLine("Id: " + proObject.Id);
            string activeString = string.Empty;
            if (proObject.Active == true) { activeString = "Ja"; } else { activeString = "Nej"; }
            Console.WriteLine("Bruger aktiv: " + activeString);
            idList.Add(proObject.Id);
            initialsList.Add(proObject.Initials);
            Console.WriteLine();
        }


        Console.WriteLine("Bekræft aktivering af bruger J/N (Ja/Nej)");
        var menuChoice = Console.ReadKey();

        switch (menuChoice.Key)
        {
            case ConsoleKey.J:
                Console.WriteLine("");
                Console.WriteLine("Bruger aktiveres... Vent venligst");
            processes.ActivateProfessional(idList[0]);
                break;
            case ConsoleKey.D:
                Console.WriteLine("");
                Console.WriteLine("Bruger deaktiveres... Vent venligst");
                processes.DeactivateProfessional(idList[0]);
                break;
            default:
                menuUserInput = 99;
                break;
        }

        var prof = processes.GetProfessional(idList[0]);
        var proStatus = prof.Active;

        if (proStatus == true)
        {
            Console.WriteLine("");
            Console.WriteLine("Brugeren " + prof.FullName + " (id: " + prof.Id + ") er aktiveret");
            Console.WriteLine("Tryk på en tast...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Brugeren " + prof.FullName + " (id: " + prof.Id + ") er deaktiveret");
            Console.WriteLine("Tryk på en tast...");
            Console.ReadLine();
        }

    }
    else
    {
        Console.WriteLine("Der er fundet mere end én med de initialer. Brug menu til fremsøgning i stedet.");
        Console.WriteLine("Tryk på en tast...");
        Console.ReadLine();
    }
    return 99;
}

#endregion options code




