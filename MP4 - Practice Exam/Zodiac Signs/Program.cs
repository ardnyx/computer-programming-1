using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP4_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Your Zodiac Sign: ");
            string zodiac = Console.ReadLine();
            Console.WriteLine("");

            if (zodiac == "Aries")
            {
                Console.WriteLine(@"Sign Facts:

Aries, the first sign in the zodiac, falls between March 21 and April 19 and is characterized as a Fire sign ruled by Mars. 
Aries individuals are known for their assertiveness, independence, and competitive nature, often displaying confidence and 
courage in pursuing their goals. They make natural leaders but can be impatient and impulsive at times. Aries is most compatible 
with Fire and Air signs, excels in careers requiring leadership and initiative, and often enjoys physical activities and challenges. 
Famous Aries include Leonardo da Vinci, Lady Gaga, and Robert Downey Jr., but it's important to remember that astrology is just 
one facet of personality, influenced by various factors beyond one's sign.

Horoscope for the Day: 06/09/2023 
Secret

Lucky Color: Red
Lucky Number: 12

Most Compatible Signs:
Leo: They both crave attention, adventure, and fun, and their enthusiasm for life can create a strong connection.
Sagittarius: They enjoy exploring new horizons together and share a love for spontaneity.
Gemini: They both appreciate variety and excitement in life, which can lead to a lively and engaging partnership.");
            }

            if (zodiac == "Taurus")
            {
                Console.WriteLine(@"Sign Facts:

Taurus, the second sign in the zodiac, spans from April 20 to May 20 and is characterized as an Earth sign ruled by Venus. 
Taurus individuals are known for their practicality, stability, and a strong connection to the material world. They are 
often reliable, patient, and persistent in pursuing their goals. While they may resist change at times, they are also deeply 
loyal and nurturing to their loved ones. Taurus is most compatible with other Earth signs (Virgo and Capricorn) and Water 
signs (Cancer, Scorpio, and Pisces), appreciating the emotional depth and reliability they offer.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Green
Lucky Number: 6

Most Compatible Signs:

Virgo: Taurus and Virgo share a practical approach to life, attention to detail, and a love for stability, making them a grounded and harmonious pair.
Capricorn: Both Taurus and Capricorn value security and material success. Their shared ambition and determination can lead to a strong and prosperous partnership.
Cancer: Taurus and Cancer connect on an emotional level, as they both appreciate the comforts of home and family. Their nurturing tendencies complement each other well.");
            }

            if (zodiac == "Gemini")
            {
                Console.WriteLine(@"Sign Facts:

Gemini, the third sign in the zodiac, spans from May 21 to June 20 and is characterized as an Air sign ruled by Mercury. 
Gemini individuals are known for their intellectual curiosity, adaptability, and communication skills. They are often seen 
as social butterflies, with a natural ability to connect with people from all walks of life. Geminis are quick thinkers and 
can easily adapt to new situations, making them versatile individuals. They can, however, be indecisive and may struggle 
with a tendency to be superficial at times. Gemini is most compatible with other Air signs (Libra and Aquarius) and Fire 
signs (Aries, Leo, and Sagittarius) who share their love for variety and mental stimulation.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Yellow
Lucky Number: 5

Most Compatible Signs:

Libra: Gemini and Libra both have a strong sense of intellectual curiosity and a love for socializing. Their shared interests and communication skills can create a harmonious bond.
Aquarius: These two Air signs appreciate their freedom and independence, making them compatible partners who enjoy exploring new ideas and experiences together.
Aries: Aries and Gemini are both adventurous and share a zest for life. Their dynamic personalities can lead to exciting and passionate encounters.");
            }

            if (zodiac == "Cancer")
            {
                Console.WriteLine(@"Sign Facts:

Cancer, the fourth sign in the zodiac, spans from June 21 to July 22 and is characterized as a Water sign ruled by the Moon. 
Cancer individuals are known for their emotional sensitivity, nurturing nature, and strong connection to their home and family. 
They are often deeply intuitive and empathetic, making them excellent caregivers and providers of emotional support. Cancer 
individuals can be protective and loyal to their loved ones but may sometimes struggle with mood swings and a tendency to hold 
onto past hurts. Cancer is most compatible with other Water signs (Scorpio and Pisces) and Earth signs (Taurus, Virgo, and Capricorn), 
who appreciate their emotional depth and stability.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Silver
Lucky Number: 2

Most Compatible Signs:

Scorpio: Cancer and Scorpio share intense emotional depth and a desire for loyalty and commitment in their relationships. They can form strong, passionate bonds.
Pisces: These two Water signs connect on a spiritual and intuitive level. They have a profound understanding of each other's emotions and can create a loving and supportive partnership.
Taurus: Taurus and Cancer both value security and the comforts of home. Their shared appreciation for stability and nurturing can lead to a harmonious and lasting relationship.");
            }

            if (zodiac == "Leo")
            {
                Console.WriteLine(@"Sign Facts:

Leo, the fifth sign in the zodiac, falls between July 23 and August 22 and is characterized as a Fire sign ruled by the Sun. 
Leo individuals are known for their confidence, charisma, and natural leadership abilities. They thrive in the spotlight and 
enjoy being the center of attention. Leos are often generous, creative, and passionate, with a strong sense of self-expression. 
However, they can also be seen as somewhat self-centered or stubborn at times. Leo is most compatible with other Fire signs 
(Aries and Sagittarius) and Air signs (Gemini, Libra, and Aquarius), who appreciate their zest for life and share their love 
for socializing.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Gold
Lucky Number: 1

Most Compatible Signs:

Aries: Leo and Aries both have strong personalities and a desire for adventure and excitement. Their shared enthusiasm and leadership qualities can lead to a dynamic and passionate relationship.
Sagittarius: These Fire signs share a love for exploration and new experiences. Their sense of adventure and optimism can make for an exciting and harmonious partnership.
Gemini: Leo and Gemini connect through their love for communication and socializing. They can engage in lively and intellectually stimulating conversations, fostering a sense of excitement in their relationship.");
            }

            if (zodiac == "Virgo")
            {
                Console.WriteLine(@"Sign Facts:

Virgo, the sixth sign in the zodiac, spans from August 23 to September 22 and is characterized as an Earth sign ruled by Mercury. 
Virgo individuals are known for their attention to detail, practicality, and strong analytical abilities. They have a natural sense 
of duty and responsibility and often excel in roles that require organization and precision. Virgos are often seen as reliable, 
modest, and service-oriented, although they can also be critical and perfectionistic. Virgo is most compatible with other Earth signs 
(Taurus and Capricorn) and Water signs (Cancer, Scorpio, and Pisces), who appreciate their dedication and practical approach to life.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Navy Blue
Lucky Number: 3

Most Compatible Signs:

Taurus: Virgo and Taurus share a practical outlook on life and value stability and security. Their shared commitment to hard work and loyalty can lead to a harmonious partnership.
Capricorn: These two Earth signs understand each other's ambitions and desire for success. Their shared work ethic and determination can create a strong and prosperous bond.
Cancer: Virgo and Cancer connect through their nurturing qualities and attention to detail. They can provide each other with emotional support and create a loving and well-organized home environment.");
            }

            if (zodiac == "Libra")
            {
                Console.WriteLine(@"Sign Facts:

Libra, the seventh sign in the zodiac, falls between September 23 and October 22 and is characterized as an Air sign ruled by Venus. 
Libra individuals are known for their love of balance, harmony, and social connections. They have a natural charm, grace, and diplomacy 
that often makes them excellent peacemakers and diplomats. Libras value fairness, justice, and beauty, and they are often drawn to artistic 
pursuits. However, they can sometimes struggle with indecision and a desire to please everyone. Libra is most compatible with other Air 
signs (Gemini and Aquarius) and Fire signs (Aries, Leo, and Sagittarius), who appreciate their social nature and share their love for 
intellectual pursuits.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Pastel Blue
Lucky Number: 7

Most Compatible Signs:

Gemini: Libra and Gemini both enjoy intellectual stimulation and socializing. Their shared interests and communication skills can create a harmonious and lively partnership.
Aquarius: These two Air signs connect through their shared love for freedom and individuality. They can engage in deep conversations about their ideals and visions for the future.
Leo: Libra and Leo can create a dynamic and stylish pair. They both appreciate beauty and social events, making them a charming and socially active couple.");
            }

            if (zodiac == "Scorpius")
            {
                Console.WriteLine(@"Sign Facts:

Scorpio, the eighth sign in the zodiac, spans from October 23 to November 21 and is characterized as a Water sign ruled by Mars and Pluto. 
Scorpio individuals are known for their intensity, passion, and deep emotional nature. They have a strong desire for truth and transformation 
and often possess great insight into human psychology. Scorpios are loyal and protective of their loved ones but can also be secretive and 
prone to jealousy. They are drawn to mysteries and uncovering hidden truths. Scorpio is most compatible with other Water signs (Cancer and Pisces) 
and Earth signs (Taurus, Virgo, and Capricorn), who appreciate their emotional depth and determination.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Deep Burgundy
Lucky Number: 8

Most Compatible Signs:

Cancer: Scorpio and Cancer connect on an emotional and intuitive level. They value loyalty and create a nurturing and deeply emotional bond.
Pisces: These two Water signs understand each other's emotional complexities. They can provide each other with spiritual and emotional support, leading to a profound and compassionate relationship.
Taurus: Scorpio and Taurus share a desire for stability and security. Their shared determination and sensuality can lead to a passionate and enduring partnership.");
            }

            if (zodiac == "Sagittarius")
            {
                Console.WriteLine(@"Sign Facts:

Sagittarius, the ninth sign in the zodiac, falls between November 22 and December 21 and is characterized as a Fire sign ruled by Jupiter. 
Sagittarius individuals are known for their adventurous spirit, love of exploration, and philosophical outlook on life. They have a strong 
desire for freedom and independence and often have a positive and optimistic attitude. Sagittarians are open-minded, honest, and enjoy taking 
risks, although they can sometimes be tactless or impatient. Sagittarius is most compatible with other Fire signs (Aries and Leo) and Air signs 
(Gemini, Libra, and Aquarius), who share their enthusiasm for life and intellectual pursuits.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Royal Blue
Lucky Number: 9

Most Compatible Signs:

Aries: Sagittarius and Aries both have adventurous and independent personalities. Their shared love for spontaneity and action can create a dynamic and passionate relationship.
Leo: These Fire signs connect through their love of excitement and socializing. They can enjoy life to the fullest and make a fun-loving and energetic pair.
Aquarius: Sagittarius and Aquarius share a sense of freedom and open-mindedness. They can engage in stimulating conversations about their shared ideals and visions for the future.");
            }

            if (zodiac == "Capricorn")
            {
                Console.WriteLine(@"Sign Facts:

Capricorn, the tenth sign in the zodiac, spans from December 22 to January 19 and is characterized as an Earth sign ruled by Saturn. 
Capricorn individuals are known for their strong work ethic, discipline, and determination to achieve their goals. They are practical, 
responsible, and often take on leadership roles. Capricorns value tradition and stability, and they are skilled at managing resources. 
However, they can be seen as reserved or overly serious at times. Capricorn is most compatible with other Earth signs (Taurus and Virgo) 
and Water signs (Cancer, Scorpio, and Pisces), who appreciate their reliability and shared commitment to building a secure future.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Charcoal Gray
Lucky Number: 4

Most Compatible Signs:

Taurus: Capricorn and Taurus share a strong sense of responsibility and a desire for stability. Their shared values and work ethic can lead to a solid and harmonious partnership.
Virgo: These two Earth signs understand each other's need for perfection and attention to detail. Their practical and analytical nature can create an organized and efficient bond.
Pisces: Capricorn and Pisces may seem different, but they can complement each other well. Capricorn's stability can balance Pisces' dreaminess, resulting in a harmonious and supportive relationship.");
            }

            if (zodiac == "Aquarius")
            {
                Console.WriteLine(@"Sign Facts:

Aquarius, the eleventh sign in the zodiac, spans from January 20 to February 18 and is characterized as an Air sign ruled by Uranus (traditional ruler Saturn). 
Aquarius individuals are known for their originality, intellectual prowess, and humanitarian outlook on life. They have a strong desire for innovation, often 
embracing unconventional ideas and social causes. Aquarians are open-minded, friendly, and value their independence, although they can sometimes be seen as 
detached or emotionally reserved. Aquarius is most compatible with other Air signs (Gemini and Libra) and Fire signs (Aries, Leo, and Sagittarius), who share 
their love for intellectual stimulation and social engagement.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Electric Blue
Lucky Number: 11

Most Compatible Signs:

Gemini: Aquarius and Gemini connect through their shared love for intellectual pursuits and socializing. They can engage in lively and intellectually stimulating conversations, fostering a sense of excitement in their relationship.
Libra: These Air signs appreciate balance and harmony in their interactions. They can create a harmonious and diplomatic partnership, often working together to promote fairness and justice.
Aries: Aquarius and Aries both have independent and adventurous personalities. Their shared enthusiasm for innovation and action can create a dynamic and progressive relationship.");
            }

            if (zodiac == "Pisces")
            {
                Console.WriteLine(@"Sign Facts:

Pisces, the twelfth and final sign in the zodiac, spans from February 19 to March 20 and is characterized as a Water sign ruled by Neptune (traditional ruler Jupiter). 
Pisces individuals are known for their compassionate, empathetic, and highly intuitive nature. They have a deep emotional depth and often possess artistic or creative 
talents. Pisceans are dreamy, idealistic, and can be deeply spiritual, but they may sometimes struggle with boundary issues and a tendency to be overly impressionable. 
Pisces is most compatible with other Water signs (Cancer and Scorpio) and Earth signs (Taurus, Virgo, and Capricorn), who appreciate their emotional depth and nurturing 
qualities.

Horoscope for the Day: 06/09/2023
Secret

Lucky Color: Seafoam Green
Lucky Number: 7

Most Compatible Signs:

Cancer: Pisces and Cancer connect on a deep emotional and intuitive level. They value loyalty, nurturing, and create a loving and empathetic bond.
Scorpio: These two Water signs understand each other's emotional complexities and can form a passionate and deeply committed partnership.
Taurus: Pisces and Taurus share a desire for stability and security. Their shared appreciation for the arts and sensuality can lead to a harmonious and creative relationship.");
            }

            Console.ReadKey();
        }
    }
}
