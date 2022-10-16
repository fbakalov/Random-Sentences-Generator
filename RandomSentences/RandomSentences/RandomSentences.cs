using System;

namespace RandomSentences
{
    class RandomSentences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Generate a sentence press \"Enter\"");
            Console.WriteLine("To stom the program type \"end\"");
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] names = {"Peter", "Michell", "Jane", "Steve", "Filip", "Denis", "Stef", "Johny", "The dog Bever", "Tsar Ferdinant", "Churchill himself", "Marta Vachkova", "Emilly", "Profesor Vuchkov"};
                string[] places = {"Sofia", "Plovdiv", "Varna", "Burgas" , "London", "under the bridge", "Luxemburg", "Bucharest", "Budapest", "the hood", "Stolipinovo", "Iraq", "Liverpool", "Zmievo villige"};
                string[] verbs = {"eats", "holds", "sees", "plays with", "brings", "shovels", "grabes", "punches", "holds by the throat", "kills", "does nothing special with", "falls on", "brakes"};
                string[] nouns = {"stones", "cake", "apple", "laptop", "bikes", "branches", "car", "the door", "peach", "building", "Jeffery Bezoz", "oranges", "purple rain", "feet", "computer"};
                string[] adverbs = {"slowly", "diligently", "warmly", "sadly", "rapidly", "dramaticly", "unfortunately", "with no regret", "full of regret", "fast", "with no shame", "proudly"};
                string[] detailes = {"near the river", "at home", "in the park", "in the backyard", "at the top of a hecking mountain", "behind the red parrot", "on top of the cake", "in the middle of the city"};
    
                string name = GetRandWord(names);
                string place = GetRandWord(places);
                string verb = GetRandWord(verbs);
                string noun = GetRandWord(nouns);
                string adverb = GetRandWord(adverbs);
                string detail = GetRandWord(detailes);
    
                Console.WriteLine($"{name} from {place} {verb} {noun} {adverb} {detail}");
            }
            
        }

        private static string GetRandWord(string[] words)
        {
            Random rand = new Random();

            int randomIndex = rand.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
    }
}
