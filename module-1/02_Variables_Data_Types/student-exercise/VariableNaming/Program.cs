using System;
using System.IO;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;
            Console.WriteLine(remainingNumberOfBirds);
            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;
            Console.WriteLine(numberOfExtraBirds);


            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int numberOfRaccoons = 3;
            int numberOfRaccoonsThatLeave = 2;
            int numberOfRaccoonsLeft = numberOfRaccoons - numberOfRaccoonsThatLeave;
            Console.WriteLine(numberOfRaccoonsLeft + " raccoons");
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int numberOfFlowers = 5;
            int numberOfBees = 3;
            int FlowersToBees = numberOfFlowers - numberOfBees;
            Console.WriteLine(FlowersToBees + " less bees than flowers");
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int firstPigeonEating = 1;
            int secondPigeonEating = 1;
            int numberOfEatingPigeons = firstPigeonEating + secondPigeonEating;
            Console.WriteLine(numberOfEatingPigeons + " pigeons eating breadcrumbs");
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int numberOfSittingOwls = 3;
            int numberOfJoiningOwls = 2;
            int numberOfTotalOwls = numberOfSittingOwls + numberOfJoiningOwls;
            Console.WriteLine(numberOfTotalOwls + " owls");
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int workingBeavers = 2;
            int leavingBeavers = 1;
            int remainingBeavers = workingBeavers - leavingBeavers;
            Console.WriteLine(remainingBeavers + " beavers");
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int sittingToucans = 2;
            int joiningToucans = 1;
            int totalToucans = sittingToucans + joiningToucans;
            Console.WriteLine(totalToucans + " toucans");
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int numberOfSquirrels = 4;
            int treeWithNuts = 2;
            int squirrelsToNuts = numberOfSquirrels - treeWithNuts;
            Console.WriteLine(squirrelsToNuts + " more squirrels");
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            int quarter = 1;
            int dime = 1;
            int nickels = 2;
            decimal totalMoney = ((quarter * .25m) + (dime * .10m) + (nickels * .05m));
            Console.WriteLine("$ " + totalMoney);
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int brierMuffins = 18;
            int macAdamsMuffins = 20;
            int flanneryMuffins = 17;
            int totalMuffins = brierMuffins + macAdamsMuffins + flanneryMuffins;
            Console.WriteLine(totalMuffins + " muffins");
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoYo = .24m;
            decimal whistle = .14m;
            decimal costOfToys = yoYo + whistle;
            Console.WriteLine("$ " + costOfToys);
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
            int riceKrispieTreats = 5;
            int largeMarshMallows = 8;
            int miniMarshMallows = 10;
            int totalMarshMallows = (largeMarshMallows + miniMarshMallows) * riceKrispieTreats;
            Console.WriteLine(totalMarshMallows + " marshmallows");

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHouseSnow = 29;
            int brecknockSchoolSnow = 17;
            int howMuchSnow = hiltHouseSnow % brecknockSchoolSnow;
            Console.WriteLine(howMuchSnow + " inches");

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            
            int moneyLeft = 10 - 3 - 2;
            Console.WriteLine("$ " + moneyLeft);

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int remainingMarbles = 16 - 7;
            Console.WriteLine(remainingMarbles + " marbles");
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int megansShells = 19;
            int shellsToGo = 25;
            int goal = shellsToGo % megansShells;
            Console.WriteLine(goal + " shells");
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBallons = 8;
            int greenBallons = totalBalloons - redBallons;
            Console.WriteLine(greenBallons + " green ballons");
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int totalBooks = 38 + 10;
            Console.WriteLine(totalBooks + " books");
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int totalBeeLegs = 6 * 8;
            Console.WriteLine(totalBeeLegs + " total legs");
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal iceCreamCost = .99m * 2;
            Console.WriteLine("$ " + iceCreamCost);
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int remainingRocks = 125 - 64;
            Console.WriteLine(remainingRocks + " rocks");
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int marblesHave = 38;
            int marblesLost = 15;
            int marblesLeft = marblesHave - marblesLost;
            Console.WriteLine(marblesLeft + " marbles");
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int milesDriven = 78;
            int milesDrove = 32;
            int milesLeft = milesDriven - milesDrove;
            Console.WriteLine(milesLeft + " miles");
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int minsInMorning = 90;
            int minsInAfterNoon = 45;
            int totalTime = minsInMorning + minsInAfterNoon;
            Console.WriteLine(totalTime + " total minutes");
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int totalHotogs = 6;
            decimal hotDogCost = .50m;
            decimal totalCost = totalHotogs * hotDogCost;
            Console.WriteLine("$ " + totalCost);
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal hiltsMoney = .50m;
            decimal pencilCost = .07m;
            decimal pencilsToBuy = hiltsMoney / pencilCost;
            Console.WriteLine(pencilsToBuy + " pencils");
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int numberOfButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = numberOfButterflies - orangeButterflies;
            Console.WriteLine(redButterflies + " red butterflies");

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal katesMoney = 1.00m;
            decimal candyCost = .54m;
            decimal change = katesMoney - candyCost;
            Console.WriteLine("$ " + change);
            {

            }
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int marksTrees = 13;
            int plantedTrees = 12;
            int totalTrees = marksTrees + plantedTrees;
            Console.WriteLine(totalTrees + " trees");
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysUntilSeeGrandma = 2;
            const int HOURSINDAY = 24;
            int joySeesGrandma = HOURSINDAY * daysUntilSeeGrandma;
            Console.WriteLine(joySeesGrandma);
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int kimsCousins = 4;
            int piecesOfGum = 5;
            int totalGum = kimsCousins * piecesOfGum;
            Console.WriteLine(totalGum + " pieces of gum");
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal dansMoney = 3.00m;
            decimal candyBarCost = 1.00m;
            decimal dansChange = dansMoney - candyBarCost;
            Console.WriteLine("$ " + dansChange);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numberOfBoats = 5;
            int numberOfPeople = 3;
            int totalPeople = numberOfBoats * numberOfPeople;
            Console.WriteLine(totalPeople + " people");
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int ellenLegos = 380;
            int lostLegos = 57;
            int totalLegos = ellenLegos - lostLegos;
            Console.WriteLine(totalLegos + " legos");
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int arthurMuffins = 35;
            int goalMuffins = 83;
            int remainingMuffins = goalMuffins - arthurMuffins;
            Console.WriteLine(remainingMuffins + " muffins");
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int moreCrayons = willyCrayons - lucyCrayons;
            Console.WriteLine(moreCrayons + " crayons");
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int numberOfStickers = 10;
            int numberOfPages = 22;
            int totalStickers = numberOfStickers * numberOfPages;
            Console.WriteLine(totalStickers + " stickers");
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int totalCupCakes = 96;
            int totalChildren = 8;
            int sharesOfCupCake = totalCupCakes / totalChildren;
            Console.WriteLine(sharesOfCupCake + " equal parts");
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int gingerBreadCookies = 47;
            int spaceForJar = 6;
            int nonPlacedCookies = (gingerBreadCookies / spaceForJar) - 6;
            Console.WriteLine(nonPlacedCookies);
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int croissants = 59;
            int neighbors = 8;
            int partsOfCroissants = croissants / neighbors;
            Console.WriteLine(partsOfCroissants + " croissants");
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int cookiesPerTray = 12;
            int totalCookies = 276;
            int numberOfTrays = totalCookies / cookiesPerTray;
            Console.WriteLine(numberOfTrays + " trays");
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int numberOfPretzels = 480;
            int servingSize = 12;
            int numberOfServings = numberOfPretzels / servingSize;
            Console.WriteLine(numberOfServings + " pretzels");
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCupcakes = 53;
            int cupCakesPerBox = 3;
            int totalBoxes = (lemonCupcakes - 3) /  cupCakesPerBox;
            Console.WriteLine(totalBoxes);
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotSticks = 74;
            int people = 12;
            int carrotsLeft = carrotSticks / people;
            Console.WriteLine(carrotsLeft + " carrots");
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int numberOfTeddyBears = 98;
            int bearsPerShelf = 7;
            int filledShelves = numberOfTeddyBears / bearsPerShelf;
            Console.WriteLine(filledShelves + " filled shelves");
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int albumPictures = 20;
            int totalPictures = 480;
            int totalAlbums = totalPictures / albumPictures;
            Console.WriteLine(totalAlbums + " albums");
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int tradingCards = 94;
            int fullBox = 8;
            int cardsInFullBoxes = tradingCards / fullBox;
            int cardsInUnfilledBoxes = tradingCards - (cardsInFullBoxes * fullBox);
            Console.WriteLine(cardsInFullBoxes + " filled boxes");
            Console.WriteLine(cardsInUnfilledBoxes + " in unfilled box");
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int numberOfBooks = 210;
            int numberOfShelves = 10;
            int booksPerShelf = numberOfBooks / numberOfShelves;
            Console.WriteLine(booksPerShelf + " books");
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            float bakedCroissants = 17;
            float numberOfGuests = 7;
            float equalPartsCroissant = bakedCroissants / numberOfGuests;
            Console.WriteLine(equalPartsCroissant + " equal parts");
            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */
            int squaredRoom = 168;
            int billPaintsPerHour = 78;
            int jillPaintsPerHour = 88;
            int hoursPerDay = 24;
            int hoursPerWorkDay = 8;
            int timeForTotalRooms = (squaredRoom * 5) / (billPaintsPerHour + jillPaintsPerHour);
            Console.WriteLine(timeForTotalRooms + " hours");
            //challenge answer//
            int daysForChallengeRooms = (squaredRoom * 623) / (billPaintsPerHour + jillPaintsPerHour) / hoursPerDay / hoursPerWorkDay;
            Console.WriteLine(daysForChallengeRooms + " days");
            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */
            string lastName = "Babington,";
            string firstName = " August";
            string midInitial = " J.";
            string fullName = lastName + firstName + midInitial;
            Console.WriteLine(fullName);

            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */
            double totalMiles = 800;
            double milesTraveled = 537;
            double percentOfCompletedTrip =  (milesTraveled / totalMiles) * 100;
            Console.WriteLine(percentOfCompletedTrip + "%");
        }
    }
}
