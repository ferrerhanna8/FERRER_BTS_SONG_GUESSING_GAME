using System;
using System.Linq;

namespace BTS_Song_Guessing_Game
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to BTS Song Guessing Game!");
			Console.WriteLine("Instructions: The game has three different levels. The first level is to guess the title of the song. The second level is to guess the missing lyrics, the title of the song is already provided. The last level is to guess which member sing that song, the title of the song is also provided.");
			Console.WriteLine("Guess the Title of the Song");
			string[] answer = { "A Brand New Day", "Butter", "Dream Glow", "Permission to Dance", "Too much", "Lost Stars", "Like A Star", "Scenery", "Sweet Night", "Winter Bear", "A Supplementary Story:You Never Walk Alone", "Suicide", "Yet to Come", "Christmas Tree", "Heartbeat", "supposed", "Deserve", "think", "dreams", "Paris", "love", "myself", "leave", "death", "Chocolate", "singing", "moment", "ARMY", "wild", "alight", "euphoria", "Jungkook", "Jungkook", "Taehyung", "RM", "Jimin", "Jimin", "RM", "RM", "Jin", "Jin", "JHope", "Suga", "JHope", "Taehyung", "Suga"};
			
			string answer1;
			string answer2;
			string answer3;
			string answer4;
			string answer5;
			string answer6;
			string answer7;
			string answer8;
			string answer9;
			string answer10;
			string answer11;
			string answer12;
			string answer13;
			string answer14;
			string answer15;
			string answer16;
			string answer17;
			string answer18;
			string answer19;
			string answer20;
			string answer21;
			string answer22;
			string answer23;
			string answer24;
			string answer25;
			string answer26;
			string answer27;
			string answer28;
			string answer29;
			string answer30;
			string answer31;
			string answer32;
			string answer33;
			string answer34;
			string answer35;
			string answer36;
			string answer37;
			string answer38;
			string answer39;
			string answer40;
			string answer41;
			string answer42;
			string answer43;
			string answer44;
			string answer45;
			int point = 0;
			
			Console.WriteLine("*I see new worlds these visions they burn inside of me. Just out of touch but still close enough to be part of me.*");
			answer1 = Console.ReadLine();
			if(answer1 == answer[0])
			{
				point += 5;
				Console.WriteLine("Correct!");
			}
			else
			{
				point -= 5;
				Console.WriteLine("Wrong!");
			}
			
			Console.WriteLine("*Side step right left to my beat. High like the moon rock with me baby.*");
			answer2 = Console.ReadLine();
			if(answer2 == answer[1])
			{
				point += 5;
				Console.WriteLine("Correct!");
			}
			else
			{
				point -= 5;
				Console.WriteLine("Wrong!");
			}
			
			Console.WriteLine("*Sometimes I stop and stare. Follow my dreams right there. Dream Glow.*");
			answer3 = Console.ReadLine();
			if(answer3 == answer[2])
			{
				point += 5;
				Console.WriteLine("Correct!");
			}
			else
			{
				point -= 5;
				Console.WriteLine("Wrong!");
			}
			
			Console.WriteLine("*When the nights get colder. And the rhythms got you falling behind.*");
			answer4 = Console.ReadLine();
			if(answer4 == answer[3])
			{
				point += 5;
				Console.WriteLine("Correct!");
			}
			else
			{
				point -= 5;
				Console.WriteLine("Wrong!");
			}
			
			Console.WriteLine("*Don't think about it too much too much too much too much. There's no need for us to rush it through.*");
			answer5 = Console.ReadLine();
			if(answer5 == answer[4])
			{
				point += 5;
				Console.WriteLine("Correct!");
			}
			else
			{
				point -= 5;
				Console.WriteLine("Wrong!");
			}
			
			Console.WriteLine("*God, tell us the reason youth is wasted on the young. It's hunting season and the lambs are on the run*");
			answer6 = Console.ReadLine();
			if(answer6 == answer[5])
			{
				point += 5;
				Console.WriteLine("Correct!");
			}
			else
			{
				point -= 5;
				Console.WriteLine("Wrong!");
			}
			
			Console.WriteLine("Just like a star across my sky. Just like a bird flying at dawn.");
			answer7 = Console.ReadLine();
			if(answer7 == answer[6])
			{
				point += 5;
				Console.WriteLine("Correct!");
			}
			else
			{
				point -= 5;
				Console.WriteLine("Wrong!");
			}
			
			Console.WriteLine("I still wonder wonder beautiful story. Still wonder wonder best part.");
			answer8 = Console.ReadLine();
			if(answer8 == answer[7])
			{
				point += 5;
			}
			else
			{
				point -= 5;
				Console.WriteLine("Wrong!");
			}
			
			Console.WriteLine("How could I know. One day, I'd wake up feeling more. But I had already reached the shore.");
		    answer9 = Console.ReadLine();
		    if(answer9 == answer[8])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    Console.WriteLine("Look like a winter bear. You sleep so happily. I wish you good night, good night, good night. Good night, good night");
		    answer10 = Console.ReadLine();
		    if(answer10 == answer[9])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    Console.WriteLine("Come on crawl, crawl, crawl. Crawl it like it like that. Baby walk, walk, walk. Walk it like it like that.");
		    answer11 = Console.ReadLine();
		    if(answer11 == answer[10])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    Console.WriteLine("I've walked this long way from home to find my real utopia. But, now I got no place to go and now I feel agoraphobia.");
		    answer12 = Console.ReadLine();
		    if(answer12 == answer[11])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    Console.WriteLine("Was it honestly the best? 'Cause I just wanna see the next.");
		    answer13 = Console.ReadLine();
		    if(answer13 == answer[12])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    Console.WriteLine("Moon in the summer night. Whispering of the stars. They're singing like Christmas trees for us.");
		    answer14 = Console.ReadLine();
		    if(answer14 == answer[13])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    Console.WriteLine("I know me before you was a ready-made me. But you designate me and you did resume me.");
		    answer15 = Console.ReadLine();
		    if(answer15 == answer[14])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    Console.WriteLine("Guess the missing lyrics.");
		    
		    Console.WriteLine("Been trying to tell you this. I was ____ to tell you this. -- 2!3!(Hoping For More Good Days)");
		    answer16 = Console.ReadLine();
		    if(answer16 == answer[15])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    Console.WriteLine("You worth it you perfect. ____ it just work it. -- 21st Century Girls");
		    answer17 = Console.ReadLine();
		    if(answer17 == answer[16])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    Console.WriteLine("All night girl. I ____ about you all night girl. -- 24/7 = Heaven");
		    answer18 = Console.ReadLine();
		    if(answer18 == answer[17])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("I know you got them big ____ too. You can show me yours if you want to. -- A Brand New Day");
		    answer19 = Console.ReadLine();
		    if(answer19 == answer[18])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("We goin' from Mexico City. London to ____. -- Airplane Pt. 2");
		    answer20 = Console.ReadLine();
		    if(answer20 == answer[19])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Marching for your ____, I'm a sergeant. I'm not from this planet, a martian. -- All Night");
		    answer21 = Console.ReadLine();
		    if(answer21 == answer[20])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("You've shown me I have reasons. I should love ____. -- Answer:Love Myself");
		    answer22 = Console.ReadLine();
		    if(answer22 == answer[21])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("You got the best of me. So please just don't ____ me.");
		    answer23 = Console.ReadLine();
		    if(answer23 == answer[22])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Oh, that would be my first ____. I been always afraid of. -- Black Swan");
		    answer24 = Console.ReadLine();
		    if(answer24 == answer[23])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Peaches and cream. Sweeter than sweet. ____ cheeks. -- Blood Sweat & Tears");
		    answer25 = Console.ReadLine();
		    if(answer25 == answer[24])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Oh this ground feels so heavier. I am ___ by myself. -- Blue & Grey");
		    answer26 = Console.ReadLine();
		    if(answer26 == answer[25])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    
            Console.WriteLine("I want something stronger. Than a ____, than a moment, love. -- Boy With Luv");
		    answer27 = Console.ReadLine();
		    if(answer27 == answer[26])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("All the playas get movin' when the bass low. Got ____ right behind us when we say so. -- Butter");
		    answer28 = Console.ReadLine();
		    if(answer28 == answer[27])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Always feeling something bigger something red ____. -- Dream Glow");
		    answer29 = Console.ReadLine();
		    if(answer29 == answer[28])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("So watch me bring the fire and set the night ____. -- Dynamite");
		    answer30 = Console.ReadLine();
		    if(answer30 == answer[29])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Guess who's member sing this part.");
            
            
            Console.WriteLine("You say love is messed up. You say that it don't work. You don't wanna try, no, no. -- Waste it on me");
		    answer31 = Console.ReadLine();
		    if(answer31 == answer[30])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Who are you? Cause you're not the girl I fell in love with. -- WHO");
		    answer32 = Console.ReadLine();
		    if(answer32 == answer[31])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Christmas without you would just not be christmas at all, pright mistletoes up above us, it's just you and me. -- Snow Flower");
		    answer33 = Console.ReadLine();
		    if(answer33 == answer[32])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("And I see swimming pools and living rooms and aeroplanes. I see a little house on the hill and children's names. -- Fools (Troye Sivan Cover)");
		    answer34 = Console.ReadLine();
		    if(answer34 == answer[33])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("I just hope you're lying next to somebody. Who knows how to love you like me. -- We don't talk anymore (Charlie Puth Cover)");
		    answer35 = Console.ReadLine();
		    if(answer35 == answer[34])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("When the nights get colder. And the rhythms got you falling behind. -- Permission to Dance");
		    answer36 = Console.ReadLine();
		    if(answer36 == answer[35])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("When you hear my heartbeat baby. You gave me a new life you gave me a new birth. -- Heartbeat");
		    answer37 = Console.ReadLine();
		    if(answer37 == answer[36])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("I'm exhausted man. Oh, guess what? I just want to go home. -- HOME");
		    answer38 = Console.ReadLine();
		    if(answer38 == answer[37])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Oh when I look in the mirror. I'll melt your heart into 2. -- Butter");
		    answer39 = Console.ReadLine();
		    if(answer39 == answer[38])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Just dream about that moment. When you look yourself, right in the eye, eye, eye. -- Permission to Dance");
		    answer40 = Console.ReadLine();
		    if(answer40 == answer[39])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("There's always something. That's standing in the way. But if you don't let it faze ya. -- Permission to Dance");
		    answer41 = Console.ReadLine();
		    if(answer41 == answer[40])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("'Cause there's no looking back. There ain't no one to prove. We don't got this on lock yeah. -- Permission to Dance");
		    answer42 = Console.ReadLine();
		    if(answer42 == answer[41])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Disco overload, I'm into that, I'm good to go. I'm diamond, you know I glow up. -- Dynamite");
		    answer43 = Console.ReadLine();
		    if(answer43 == answer[42])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("Bring a friend, join the crowd, whoever wanna come along. -- Dynamite");
		    answer44 = Console.ReadLine();
		    if(answer44 == answer[43])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
            Console.WriteLine("This rap is a gentleman's rap, I'm not insulting you. It's just some advice that you should take to heart. -- DISS");
		    answer45 = Console.ReadLine();
		    if(answer45 == answer[44])
		    {
		    	point += 5;
		    	Console.WriteLine("Correct!");
		    }
		    else
		    {
		    	point -= 5;
		    	Console.WriteLine("Wrong!");
		    }
		    
		    Console.WriteLine("Congratulations! You did great!");
            
		}
	}
}