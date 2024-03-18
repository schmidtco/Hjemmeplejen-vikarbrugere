//// See https://aka.ms/new-console-template for more information



//using Microsoft.VisualBasic;
//using Newtonsoft.Json;
//using NexusAPIWrapper;

//NexusAPI_processes processes = new NexusAPI_processes("review");
//var api = processes.api;
//#region Main

//#region Welcome/Menu

//int numberOfOptions = 3;
//string menuUserInputString = "99";
//int menuUserInput;
//bool isInt = int.TryParse(menuUserInputString, out menuUserInput);

////While the user inputs other values than the options given, we present the menu to the user
//while (menuUserInput != 0)
//{
//    Console.WriteLine("Velkommen");
//    Console.WriteLine("Vælg fra menuen.");
//    Console.WriteLine("1. Aktiver alle vikarbrugere.");
//    Console.WriteLine("2. Fremsøg bruger der ønskes aktiveret.");
//    Console.WriteLine("3. Aktiver vikarbruger med kendt Id.");
//    Console.WriteLine("0. Afslut");
//    Console.WriteLine();
//    menuUserInputString = Console.ReadLine();
//    while (menuUserInput > 0 || menuUserInput < numberOfOptions + 1)
//    {
//        switch (menuUserInput)
//        {
//            case 1:
//                #region Menu option 1
//                processes.ActivateInactiveSubstituteProfessionals();
//                break;
//                #endregion Menu option 1
//            case 2:
//                #region Menu option 2
//                string userInputSearchString = "Jette Nielsen";
//                var professionals = api.GetProfessionals(userInputSearchString);
//                int professionalsCount = professionals.Count;
//                string personsFoundText;

//                switch (professionalsCount)
//                {
//                    case 1:
//                        personsFoundText = "person";
//                        break;
//                    default:
//                        personsFoundText = "personer";
//                        break;
//                }

//                Console.WriteLine("Der blev fundet " + professionalsCount + " " + personsFoundText + " med navnet " + userInputSearchString);
//                Console.WriteLine();
//                List<int> idList = new List<int>();
//                foreach (var pro in professionals)
//                {
//                    Professional_Root proObject = JsonConvert.DeserializeObject<Professional_Root>(pro.Value.ToString());
//                    Console.WriteLine("Fulde navn: " + proObject.FullName);
//                    Console.WriteLine("Initialer: " + proObject.Initials);
//                    Console.WriteLine("Id: " + proObject.Id);
//                    string activeString = string.Empty;
//                    if (proObject.Active == true) { activeString = "Ja"; } else { activeString = "Nej"; }
//                    Console.WriteLine("Bruger aktiv: " + activeString);
//                    idList.Add(proObject.Id);
//                    Console.WriteLine();
//                }


//                Console.WriteLine("Tast Id for den bruger du ønsker aktiveret: ");
//                Console.WriteLine("");
//                string userInputString = Console.ReadLine();

//                isInt = false;
//                int menu2UserInput;

//                isInt = int.TryParse(userInputString, out menu2UserInput);

//                Professional_Root chosenPro = new Professional_Root();

//                bool idFromListChosen = false;
//                foreach (int id in idList)
//                {
//                    if (menu2UserInput == id)
//                    {
//                        idFromListChosen = true;
//                        break;
//                    }
//                }


//                if (idFromListChosen) 
//                {
//                    foreach (var pro in professionals)
//                    {
//                        Professional_Root proObject = JsonConvert.DeserializeObject<Professional_Root>(pro.Value.ToString());

//                        if (proObject.Id == menu2UserInput)
//                        {
//                            chosenPro = proObject; break;
//                        }
//                    }

//                    Console.WriteLine("Du har valgt:");
//                    Console.WriteLine("Fulde navn: " + chosenPro.FullName);
//                    Console.WriteLine("Initialer: " + chosenPro.Initials);
//                    Console.WriteLine("Id: " + chosenPro.Id);

//                    Console.WriteLine("Bekræft aktivering af bruger J/N (Ja/Nej)");
//                    var choice = Console.ReadKey();

//                    switch (choice.Key)
//                    {
//                        case ConsoleKey.J:
//                            processes.ActivateProfessional(menu2UserInput);
//                            break;
//                        default:
//                            menuUserInput = 0;
//                            break;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Du valgte ikke et Id der var på listen");
//                }
                
//                break;
//            #endregion Menu option 2
//            case 3:
//                #region Menu option 3

//                break;
//            #endregion Menu option 3
//            case 4:
//                #region Menu option 4
//                // Do nothing
            
//                break;
//            #endregion Menu option 4
//            default:
//                Console.WriteLine("Du har valgt en forkert mulighed - prøv igen.");
//                Console.WriteLine();
//                Console.WriteLine("1. Aktiver alle vikarbrugere.");
//                Console.WriteLine("2. Fremsøg bruger der ønskes aktiveret.");
//                Console.WriteLine("3. Aktiver vikarbruger med kendt Id.");
//                Console.WriteLine("0. Afslut");

//                menuUserInputString = Console.ReadLine();
//                isInt = int.TryParse(menuUserInputString, out menuUserInput);
//                break;
//        }
//    }
//}


//#endregion Welcome/Menu






//#endregion Main




