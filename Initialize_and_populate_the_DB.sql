use dbMededaEF;

DBCC CHECKIDENT (Users, RESEED, 0);

DBCC CHECKIDENT (Art, RESEED, 0);



--delete from Users;
--delete from Art;
--Where ArtId=24;

--Update Art
--set Discriminator ='VisualArt'
--Where ArtId =21;
-------------------------------------------------------------
--DAVINCI
INSERT INTO Users  (UserName,FirstName,LastName, Bio,password) VALUES  ('Leonardo Da Vinci','Leonardo','Davinci','Italian','password123');

UPDATE Users
SET Bio = 'Leonardo da Vinci(15 April 1452 – 2 May 1519) was an Italian polymath of the High Renaissance
who was active as a painter, draughtsman, engineer, scientist, theorist, sculptor, and architect. While his
fame initially rested on his achievements as a painter, he also became known for his notebooks, in which he
made drawings and notes on a variety of subjects, including anatomy, astronomy, botany, cartography, 
painting, and paleontology. Leonardo is widely regarded to have been a genius who epitomized the Renaissance
humanist ideal, and his collective works comprise a contribution to later generations of artists matched only
by that of his younger contemporary, Michelangelo.h', 
FirstName= 'Leonardo', LastName='Da VInci'
WHERE UserID = 1;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\davinciProfilePic.jpg', Single_Blob)  ProfilePic)
WHERE UserId =1;


--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'The Virgin of the Rocks','The Virgin of the Rocks, sometimes the Madonna of the Rocks, is the name of two paintings by the Italian
Renaissance artist Leonardo da Vinci, of the same subject, with a composition which is identical except for several
significant details. The version generally considered the prime version, the earlier of the two, is unrestored and 
hangs in the Louvre in Paris. The other, which was restored between 2008 and 2010, hangs in the National Gallery, London. ',3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\TheVirginoftheRocks.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Renaissance' 
WHERE ArtId = 1;

INSERT INTO ArtUser
Values(1,1);

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Grotesque Head of a Woman', 'These drawings represent Leonardo’s most sustained exploration of human physiognomy. Drawing as a 
system for studying nature and preparing other works of art—as the most basic system of representation in the Western 
tradition—was barely a generation old when he made these drawings, between c. 1495 and 1506/1508. Leonardo, who owned 
the principal early treatises on physiognomy and wrote about it in his notebooks, was the first artist to take that 
system beyond ideal types. He used it to attempt the most minute physical variations and to reach beyond surface appearance
to evoke personality and convey character.' ,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\grotesque.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Renaissance' 
WHERE ArtId = 2;

INSERT INTO ArtUser
Values(1,2);


INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'La belle Ferroniere','La Belle Ferronnière is a portrait of a lady, usually
attributed to Leonardo da Vinci, in the Louvre. It is also known as Portrait of an Unknown Woman. The paintings title,
applied as early as the seventeenth century, identifying the sitter as the wife or daughter of an ironmonger (a ferronnier), 
was said to be discreetly alluding to a reputed mistress of Francis I of France, married to a certain Le Ferron. Later she
was identified as Lucretia Crivelli, a married lady-in-waiting to Duchess Beatrice of Milan, who became another of the
Dukes mistresses.' ,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\LabelleFerroniere.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Renaissance' 
WHERE ArtId = 3;


INSERT INTO ArtUser
Values(1,3);

---------------------------------------------------------------------------

--VINCENT VAN GOGH

INSERT INTO Users  (UserName,FirstName,LastName, Bio,password) VALUES  ('Vincent Van Gogh','Vincent','VanGogh','Dutch','password123');

UPDATE Users
SET Bio = 'Vincent Willem van Gogh (30 March 1853 – 29 July 1890) was a Dutch Post-Impressionist painter who
posthumously became one of the most famous and influential figures in Western art history. In a decade, he 
created about 2,100 artworks, including around 860 oil paintings, most of which date from the last two years 
of his life. They include landscapes, still lifes, portraits and self-portraits, and are characterised by
bold colours and dramatic, impulsive and expressive brushwork that contributed to the foundations of modern
art. Not commercially successful, he struggled with severe depression and poverty, eventually leading to
his suicide at age thirty-seven.', 
FirstName= 'Vincent', LastName='Van Gogh'
WHERE UserID = 2;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\vangoghProfilePic.jpg', Single_Blob)  ProfilePic)
WHERE UserId =2;

--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Head of the Prostitute','This woman may not look like a prostitute at first glance. But in the nineteenth century, loose hair was
--a sign of loose morals. Vincent van Gogh initially considered painting portraits an effective means of earning money, but his 
--intentions soon became more serious. He wanted to capture the soul and character of his models. He perceived the intensity of
--modern life in the ‘heads’ of prostitutes. In this portrait, Van Gogh used rough brushstrokes to paint her face. He succeeded
--in giving her features volume and life.',3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\HeadoftheProstitute.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Impressionism' 
WHERE ArtId = 4;

INSERT INTO ArtUser
Values(2,4);

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)  
SELECT 'Self Portrait','Dutch Post-Impressionist painter Vincent van Gogh painted a self-portrait in oil on canvas in September 1889. 
The work, which may have been Van Goghs last self-portrait, was painted shortly before he left
Saint-Rémy-de-Provence in southern France.The painting is now at the Musée dOrsay in Paris.' ,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\SelfPortrait.jpg', Single_Blob) as BulkColumn;


UPDATE Art
SET Genre = 'Impressionism' 
WHERE ArtId = 5;

INSERT INTO ArtUser
Values(2,5);


------------------------------------------------------------------------------------

--PICASO

INSERT INTO Users  (UserName,FirstName,LastName, Bio,password) VALUES  ('Pablo Picasso','Pablo', 'Picasso','Spanish','password123');

UPDATE Users
SET Bio = 'Pablo Ruiz Picasso(25 October 1881 – 8 April 1973) was a Spanish painter, sculptor, printmaker,
ceramicist and theatre designer who spent most of his adult life in France. One of the most influential 
artists of the 20th century, he is known for co-founding the Cubist movement, the invention of constructed
sculpture, the co-invention of collage, and for the wide variety of styles that he helped develop and explore.
Among his most famous works are the proto-Cubist Les Demoiselles dAvignon (1907), and the anti-war painting 
Guernica (1937), a dramatic portrayal of the bombing of Guernica by German and Italian air forces during the
Spanish Civil War. ', 
FirstName= 'Pablo', LastName='Picasso'
WHERE UserID = 3;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\picasoProfilePic.jpg', Single_Blob)  ProfilePic)
WHERE UserId =3;

--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'La Lecture','La Lecture (or Reading) is a painting by Spanish artist Pablo Picasso completed in January 1932. 
The oil painting depicts Picassos mistress and muse, Marie-Thérèse Walter, asleep with a book upon her lap. 
The painting led to the breakup of Picassos marriage to Olga Khokhlova after she saw it at a retrospective exhibition and realised that the facial features were not her own.
The painting went to auction in 1989 and in 1996, where it failed to sell. 
In January 2011, it was announced that La Lecture would be going to auction on 8 February. 
The painting, which had not been seen in Europe since the exhibition, was then displayed at Sothebys in Paris.' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\LaLecture.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Surrealism' 
WHERE ArtId = 6;

INSERT INTO ArtUser
Values(3,6);


INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Zwei Gesichter','This painting represents the juxtaposition or uneven overlapping of different aspects of our personalities. 
We are aware of some aspects. Others are lost in our subconscious. 
They are hidden in the ‘Shadow’ of our individual egos and manifest themselves, when we expect them the least- like whhen we are helpless, or desperate. 
These aspects somehow fit in with one other and make up our personality which almost shows many faces at te same time.'
,3,'VisualArt',BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\ZweiGesichter.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Surrealism' 
WHERE ArtId = 7;

INSERT INTO ArtUser
Values(3,7);

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Le Coq','In 1938, Picasso introduced cockerel imagery into his work, exploring the birds movements and facial contortions.
This return to the theme in 1943 sees a more reductionist approach to the subject matter. Here, the birds body appears clipped and tight,
though the motion of flapping wings, featured explicitly in earlier works, is depicted by the orange and red fan shape that energetically breaks free from the restrained background. 
The exaggerated circular motion of the tail feathers also creates a sense of movement, in contrast to the tight, angular pyramidal structure of the body. ' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\LeCoq.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Surrealism' 
WHERE ArtId = 8;

INSERT INTO ArtUser
Values(3,8);


INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'The Young Ladies of Avignon','Sunset on the Seine at Lavacourt, Winter Effect is an Impressionist Oil on Canvas Painting created by Claude Monet in 1880. 
It lives at the Petit Palais, Paris in Paris.' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\Avignon.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Surrealism' 
WHERE ArtId = 9;

INSERT INTO ArtUser
Values(3,9);

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)  
SELECT 'Femme Accroupie','This work, from 1899, is exquisite in its composition of background trees, weeping willow, and the bridge, 
which underwent many alterations up to 1910. The pond here is literally obliterated by vegetation and lilies. 
It is composed of short brushstrokes - a familiar method during his mature years. In a letter, 
Monet described how he had planted the water lilies for fun - he had never intended painting them, however, 
once they established themselves they almost became his only source of inspiration. He wrote: "I saw, all of a sudden, 
that my pond had become enchanted... Since then, I have had no other model." ' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\FemmeAccroupie.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Surrealism' 
WHERE ArtId = 10;

INSERT INTO ArtUser
Values(3,10);


INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)  
SELECT 'Jeune Fille a la Mandoline','The Persistence of Memory (Catalan: La persistència de la memòria) is a 1931 painting by artist Salvador Dalí and one of the most recognizable works of Surrealism. 
First shown at the Julien Levy Gallery in 1932, since 1934 the painting has been in the collection of the Museum of Modern Art (MoMA) in New York City, which received it from an anonymous donor.
It is widely recognized and frequently referred to in popular culture, and sometimes referred to by more descriptive titles, such as "Melting Clocks", "The Soft Watches" or "The Melting Watches". ' 
,3,'VisualArt',BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\JeuneFille.jpg', Single_Blob) as BulkColumn;


UPDATE Art
SET Genre = 'Surrealism' 
WHERE ArtId = 11;

INSERT INTO ArtUser
Values(3,11);



---------------------------------------------------------------------------------------

--CLAUDE MONET


INSERT INTO Users   (UserName,FirstName,LastName, Bio,password) VALUES  ('Claude Monet','Claude' ,'Monet','French','password123');

UPDATE Users
SET Bio = 'Oscar-Claude Monet (14 November 1840 – 5 December 1926) was a French painter and founder of 
impressionist painting who is seen as a key precursor to modernism, especially in his attempts to paint 
nature as he perceived it.During his long career, he was the most consistent and prolific practitioner of 
impressionisms philosophy of expressing ones perceptions before nature, especially as applied to plein air 
(outdoor) landscape painting. The term "Impressionism" is derived from the title of his painting Impression,
soleil levant, exhibited in 1874 (the "exhibition of rejects") initiated by Monet and his associates as an
alternative to the Salon. ', 
FirstName= 'Claude', LastName='Monet'
WHERE UserID = 4;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\claudemonetProfilePic.jpg', Single_Blob)  ProfilePic)
WHERE UserId =4;

--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Soleil couchant sur la seine','The elephant is a recurring theme in the works of Dalí, first appearing in his 1944 work Dream Caused by the Flight of a Bee Around a Pomegranate a Second Before Awakening,
and also in The Temptation of Saint Anthony and Swans Reflecting Elephants. 
The Elephants differs from the other paintings in that the animals are the primary focus of the work, 
with a barren graduated background and lack of other content, 
where most of Dalís paintings contain much detail and points of interest 
(for example Swans Reflecting Elephants which is somewhat better known within Dalís repertoire than The Elephants). 
The stork-legged elephant is one of the best-known icons of Dalís work. ' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\Soleilcouchantsurlaseine.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Impressionism' 
WHERE ArtId =12;

INSERT INTO ArtUser
Values(4,12);

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)  
SELECT 'Water Lilly Pond', 'The Milkmaid (Dutch: De Melkmeid or Het Melkmeisje), 
sometimes called The Kitchen Maid, is an oil-on-canvas painting of a "milkmaid", in fact, a domestic kitchen maid, 
by the Dutch artist Johannes Vermeer. It is now in the Rijksmuseum in Amsterdam, 
the Netherlands, which regards it as "unquestionably one of the museums finest attractions".' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\WaterLillyPond.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Impressionism' 
WHERE ArtId =13;

INSERT INTO ArtUser
Values(4,13);




------------------------------------------------------------------------------------------

--SALVADOR DALI 

INSERT INTO Users  (UserName,FirstName,LastName, Bio,password) VALUES  ('Salvador Dali','Salvador', 'Dali','Spanish','password123');

UPDATE Users
SET Bio = 'Salvador Domingo Felipe Jacinto Dalí i Domènech(11 May 1904 – 23 January 1989), known as Salvador
Dalí was a Spanish surrealist artist renowned for his technical skill, precise draftsmanship, and the striking
and bizarre images in his work', 
FirstName= 'Salvador', LastName='Dali'
WHERE UserID = 5;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\salvadordaliProfilePic.jpg', Single_Blob)  ProfilePic)
WHERE UserId =5;

--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)
SELECT 'The Persistence of Memory', 'Girl with a Pearl Earring (Dutch: Meisje met de parel) is an oil painting by Dutch Golden Age painter Johannes Vermeer,
dated c. 1665. Going by various names over the centuries, it became known by its present title towards the end of the 20th century
after the earring worn by the girl portrayed there. The work has been in the collection of the Mauritshuis in The Hague since 1902 and has been the
subject of various literary and cinematic treatments. ' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\ThePersistenceofMemory.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Surrealism' 
WHERE ArtId = 14;

INSERT INTO ArtUser
Values(5,14);



INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)
SELECT 'The Elephants','Lady Writing a Letter with her Maid (Dutch: Schrijvende vrouw met dienstbode) is a painting by the Dutch artist Johannes Vermeer, 
completed in 1670–1671 and held in the National Gallery of Ireland, in Dublin. 
The work shows a middle-class woman attended by a housemaid who is presumably acting as messenger and go-between for the lady and her lover. 
The work is seen as a bridge between the quiet restraint and self-containment of Vermeers work of the 1660s and his relatively cooler work of the 1670s.
It may have been partly inspired by Ter Borchs painting Woman Sealing a Letter. 
The paintings canvas was almost certainly cut from the same bolt used for Woman with a Lute. ' 
 ,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\TheElephants.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Surrealism' 
WHERE ArtId = 15;

INSERT INTO ArtUser
Values(5,15);



-------------------------------------------------------------------------------------------------

--JOHANNED VERMEER

INSERT INTO Users  (UserName,FirstName,LastName, Bio,password) VALUES  ('Johannes Vermeer','Johannes' ,'Vermeer','Dutch','password123');

UPDATE Users
SET Bio = 'Johannes Vermeer (October 1632 – 15 December 1675) was a Dutch Baroque Period painter who specialized
in domestic interior scenes of middle-class life. During his lifetime, he was a moderately successful provincial
genre painter, recognized in Delft and The Hague. Nonetheless, he produced relatively few paintings and evidently
was not wealthy, leaving his wife and children in debt at his death. ', 
FirstName= 'Johannes', LastName='Vermeer'
WHERE UserID = 6;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\johannesvermeerProfilePic.jpg', Single_Blob)  ProfilePic)
WHERE UserId =6;

--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)
SELECT 'Maid with a Milk Jug', 'The Anatomy Lesson of Dr. Nicolaes Tulp is a 1632 oil painting on canvas by Rembrandt housed in the 
Mauritshuis museum in The Hague, the Netherlands. The painting is regarded as one of Rembrandts early masterpieces. 
In the work, Nicolaes Tulp is pictured explaining the musculature of the arm to a group of doctors. 
Some of the spectators are various doctors who paid commissions to be included in the painting. 
The painting is signed in the top-left hand corner Rembrandt. f1632. 
This may be the first instance of Rembrandt signing a painting with his forename (in its original form) as opposed to the monogram RHL 
(Rembrandt Harmenszoon of Leiden), and is thus a sign of his growing artistic confidence.' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\MaidwithaMilkJug.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Baroque' 
WHERE ArtId = 16;

INSERT INTO ArtUser
Values(6,16);


INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)
SELECT 'Girl with a Pearl Earring','Self-Portrait with Two Circles is one of more than 40 self-portraits Rembrandt painted 
(as well as a similar number in other media) and one of a number of depictions in several media dating at least from 1629 
that show him at work drawing, etching, or painting. He wears a fur-lined robe, beneath which is a red garment. On his head is a white hat, 
similar to that worn in several other late self-portraits. Unlike other late self-portraits, in Self-Portrait with Two Circles, Rembrandt, 
with one hand on his hip, appears confrontational and even defiant. The impression is that of a master solemnly asserting his genius.' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\GirlwithaPearlEarring.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Baroque' 
WHERE ArtId = 17;

INSERT INTO ArtUser
Values(6,17);


INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)
SELECT 'Woman writing a letter with her maid',' It is among the Dutch masters final works, 
likely completed within two years of his death in 1669.[1] Depicting the moment of the prodigal sons return to his father in the Biblical parable,
it is a renowned work described by art historian Kenneth Clark as "a picture which those who have seen the original in St. 
Petersburg may be forgiven for claiming as the greatest picture ever painted".[2]
--In the painting, the son has returned home in a wretched state from travels in which he has wasted his inheritance and fallen 
into poverty and despair. He kneels before his father in repentance, wishing for forgiveness and the position of a servant in his fathers household
, having realized that even his fathers servants had a better station in life than he. His father receives him with a tender gesture and welcomes 
him as his own son. ' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\Womanwritingaletterwithhermaid.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Baroque' 
WHERE ArtId = 18;

INSERT INTO ArtUser
Values(6,18);


-------------------------------------------------------------------------------------------------------------------

--REMBRANDT VAN RIJN

INSERT INTO Users  (UserName,FirstName,LastName, Bio,password) VALUES  ('Rembrandt van Rijn','Rembrandt' ,'vanRijn','Dutch','password123');


UPDATE Users
SET Bio = 'Rembrandt Harmenszoon van Rijn (15 July 1606 – 4 October 1669), usually simply known as Rembrandt, was
a Dutch Golden Age painter, printmaker and draughtsman. An innovative and prolific master in three media, he is 
generally considered one of the greatest visual artists in the history of art and the most important in Dutch art 
history. ', 
FirstName= 'Remberandt', LastName='Van Rijn'
WHERE UserID = 7;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\rembrandtharmenszoonProfilePic.jpeg', Single_Blob)  ProfilePic)
WHERE UserId =7;

--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'The Anatomy Lesson of Dr Nicolaes', 'The Last Judgment (Italian: Il Giudizio Universale) is a fresco by the Italian Renaissance painter
Michelangelo covering the whole altar wall of the Sistine Chapel in Vatican City. 
It is a depiction of the Second Coming of Christ and the final and eternal judgment by God of all humanity. 
The dead rise and descend to their fates, as judged by Christ who is surrounded by prominent saints. 
Altogether there are over 300 figures, with nearly all the males and angels originally shown as nudes;
many were later partly covered up by painted draperies, of which some remain after recent cleaning and restoration. 
The work took over four years to complete between 1536 and 1541' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\TheAnatomyLessonofDrNicolaes.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Baroque' 
WHERE ArtId = 19;

INSERT INTO ArtUser
Values(7,19)


INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Self-Portrait with Two Circles','"The Ignudi" is the phrase coined by Michelangelo to describe the 20 seated male nudes he 
incorporated into the Sistine Chapel ceiling frescoes. These figures are interesting in that they do not fit the theme of the paintings, 
so their true meaning has been a mystery in the art world.
The word ignudi comes from the Italian adjective nudo, meaning "naked." The singular form is ignudo. Michelangelo adopted the name
"The Ignudi" for his 20 figures, giving it a new art-historical context.
The youthful, athletic male figures are depicted in pairs of four. Each pair surrounds five center panels on the ceiling of the Sistine Chapel 
(there are nine panels in total). The ignudi appear on the panels: "The Drunkenness of Noah," "The Sacrifice of Noah," "The Creation of Eve," "
The Separation of Land from Water," and "The Separation of Light from Darkness." ' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\SelfPortraitwithTwoCircles.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Baroque' 
WHERE ArtId = 20;

INSERT INTO ArtUser
Values(7,20)

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Return of the Prodigal Son','Renoir would have called this work an impression,
a finished painting of a dramatic atmospheric effect rather than a sketch of a specific site. 
The sea is heavily worked with layers of color, the sky is painted in broad, rapid brushstrokes. 
The elevated viewpoint looks out across the water, where a small boat suggests a sense of scale and an indication of human presence.' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\ReturnoftheProdigalSon.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Baroque' 
WHERE ArtId = 21;

INSERT INTO ArtUser
Values(7,21);





---------------------------------------------------------------------------------------------------------------------

--MICHELANGELO BURINAROTTI

INSERT INTO Users  (UserName,FirstName,LastName, Bio,password) VALUES  ('Michelangelo Buonarotti','Michelangelo', 'Buonarotti','Italian','password123');

UPDATE Users
SET Bio = 'Michelangelo di Lodovico Buonarroti Simoni (6 March 1475 – 18 February 1564), known as Michelangelo, was
an Italian sculptor, painter, architect, and poet of the High Renaissance. Born in the Republic of Florence, his work
was inspired by models from classical antiquity and had a lasting influence on Western art.', 
FirstName= 'Michelangelo', LastName='Buonarotti'
WHERE UserID = 8;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\michelangeloProfilePic.jpg', Single_Blob)  ProfilePic)
WHERE UserId =8;

--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Giudizio Universale',' Renoir painted about 4000 paintings that have sold at auction for as much as $78.1 million (in 1990). 
The largest collection of Renoir paintings is at the Barnes Foundation in Philadelphia, Pennsylvania, United States.' 
 ,3, 'VisualArt',BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\GiudizioUniversale.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Renaissance' 
WHERE ArtId = 22;

INSERT INTO ArtUser
Values(8,22);


INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Ignudo', 'Matisses Open Window, Collioure is an icon of early modernism. A small but explosive work, it is celebrated as one of the 
most important early paintings of the so-called fauve school, a group of artists, including André Derain, Maurice de Vlaminck, and Georges Braque,
that emerged in 1904. Fauve paintings are distinguished by a startling palette of saturated, unmixed colors and broad brushstrokes. 
The effect is one of spontaneity, although the works reveal a calculated assimilation of techniques from postimpressionism and neo-impressionism.
Open Window represents the very inception of the new manner in Matisses art. 
It was painted in Collioure, a small town on the Mediterranean coast of France to which Matisse traveled with Derain in the summer of 1905.' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\Ignudo.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Renaissance' 
WHERE ArtId = 23;

INSERT INTO ArtUser
Values(8,23);

--------------------------------------------------------------------------------------------------------------------------
--PIERRE-AUGUSTE RENOIR
INSERT INTO Users  (UserName,FirstName,LastName, Bio,password) VALUES  ('Pierre-Auguste Renoir','Pierre-Auguste', 'Renoir','French','password123');

UPDATE Users
SET Bio = 'Pierre-Auguste Renoir (25 February 1841 – 3 December 1919) was a French artist who was a leading painter in 
the development of the Impressionist style. As a celebrator of beauty and especially feminine sensuality, it has been 
said that "Renoir is the final representative of a tradition which runs directly from Rubens to Watteau." ', 
FirstName= 'Pierre-Auguste', LastName='Renoir'
WHERE UserID = 9;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\pierreaugusteProfilePic.jpg', Single_Blob)  ProfilePic)
WHERE UserId =9;

--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Sunset at Sea','Cat With Red Fish" by Henri Matisse is a popular painting from his famous collection In this painting it is seen that
Matisse had an exceptional love for cats (and also doves). His cats were called Minouche, Coussi, and La Puce the black cat. Coussi, it is said,
had an “M” for Matisse on his forehead. His breakthrough as an artist came during the summers of 1904 and 1905, when the bright sunlight of 
the South of France inspired him along with artists like André Derain and Maurice de Vlaminck to create optically dynamic works of bright, 
clashing colours that led to these artists being derided with the epithet fauves. Known as Fauvism, the work from this period set him on a 
career-long path that he described as “construction by coloured surfaces.” This approach remained central through the various stages of Matisse’s
body of work from his rigorous, abstracted paintings of the 1910s to the decorative, sunlit interiors of his so-called 
“Nice period” of the 1920s to the radically innovative cut-outs of his last decade. ' 
 ,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\SunsetatSea.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Impressionism' 
WHERE ArtId = 24;

INSERT INTO ArtUser
Values(9,24);



INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Catalogue Raisonne','Dance (La Danse) is a painting made by Henri Matisse in 1910, at the request of Russian businessman and 
art collector Sergei Shchukin, who bequeathed the large decorative panel to the Hermitage Museum in Saint Petersburg, Russia. 
The composition of dancing figures is commonly recognized as "a key point of (Matisses) career and in the development of modern painting".
A preliminary version of the work, sketched by Matisse in 1909 as a study for the work, resides at MoMA in New York City, where
it has been labeled Dance. ' 
,3, 'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\CatalogueRaisonne.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Impressionism' 
WHERE ArtId = 25;

INSERT INTO ArtUser
Values(9,25);



----------------------------------------------------------------------------------------------------------------------------

--HENRI MATISSE
INSERT INTO Users  (UserName,FirstName,LastName, Bio,password) VALUES  ('Henri Matisse','Henri', 'Matisse','French','password123');

UPDATE Users
SET Bio = 'Henri Émile Benoît Matisse (31 December 1869 – 3 November 1954) was a French visual artist, known for both 
his use of colour and his fluid and original draughtsmanship. He was a draughtsman, printmaker, and sculptor, but is
known primarily as a painter. Matisse is commonly regarded, along with Pablo Picasso, as one of the artists who best 
helped to define the revolutionary developments in the visual arts throughout the opening decades of the twentieth 
century, responsible for significant developments in painting and sculpture.', 
FirstName= 'Henri', LastName='Matisse'
WHERE UserID = 10;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\HenriÉmileBenoîtProfilePic.jpg', Single_Blob)  ProfilePic)
WHERE UserId =10;

--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Open Window at Collioure', 'In 1504 the young Raphael came from Perugia to Florence, where Leonardo da Vinci and Michelangelo 
dominated artistic life. Especially under the influence of Leonardo’s compositions, the newcomer created a series of Madonna depictions. 
Particularly in Florence, the Madonna image had experienced a change in function: it was no longer mainly a religious item for practical use,
but primarily an exquisite expression of artistic achievement. Raphael gave the Madonna in the Meadow to his Florentine patron Taddeo Taddi as a
gift; in 1662 it was acquired at its place of origin by Archduke Ferdinand Karl of Tirol.' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\OpenWindowatCollioure.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Impressionism' 
WHERE ArtId = 26;

INSERT INTO ArtUser
Values(10,26)

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)  
SELECT 'The Cat with Red Fish','The Sistine Madonna, also called the Madonna di San Sisto, is an oil painting by the Italian artist Raphael. 
The painting was commissioned in 1512 by Pope Julius II for the church of San Sisto, Piacenza, and probably executed c. 1513–1514. 
The canvas was one of the last Madonnas painted by Raphael. Giorgio Vasari called it "a truly rare and extraordinary work".
--The painting was moved to Dresden from 1754 and is well known for its influence in the German and Russian art scene. After World War II,
it was relocated to Moscow for a decade before being returned to Germany. ' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\TheCatwithRedFish.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Impressionism' 
WHERE ArtId = 27;

INSERT INTO ArtUser
Values(10,27)

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image)  
SELECT 'Dance', 'OKeeffe began creating simplified images of natural things, such as leaves, flowers, and rocks. 
Inspired by Precisionism, the painting depicts her notion of simple, meaningful life. OKeeffe said that year, "it is only by selection,
by elimination, and by emphasis that we get at the real meaning of things." Blue and Green Music expresses OKeeffes feelings 
about music through visual art, using bold and subtle colors.' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\Dance.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Impressionism' 
WHERE ArtId = 28;

INSERT INTO ArtUser
Values(10,28)






-----------------------------------------------------------------------------------------------------------------------------------
--RAPHAEL SANZIO
INSERT INTO Users  (UserName,FirstName,LastName, Bio,password) VALUES  ('Raphael Sanzio da Urbino','Raphael', 'Sanzio','Italian','password123');

UPDATE Users
SET Bio = 'Raffaello Sanzio da Urbino, better known as Raphael (March 28 or April 6, 1483 – April 6, 1520), was an Italian
painter and architect of the High Renaissance. His work is admired for its clarity of form, ease of composition, and visual
achievement of the Neoplatonic ideal of human grandeur. Together with Leonardo da Vinci and Michelangelo, he forms the 
traditional trinity of great masters of that period. ', 
FirstName= 'Raphael', LastName='De Urbino'
WHERE UserID = 11;

UPDATE Users
SET ProfilePic = (SELECT BulkColumn FROM Openrowset(Bulk 'C:\Users\zelal\Pictures\pictures\RaffaelloSanzioProfilePic.jpg', Single_Blob)  ProfilePic)
WHERE UserId =11;

--ArtWorks

INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'Madonna in Meadow','This painting is quite simple. It features a close-up image of a blue flower.
Georgia carefully and beautifully utilized colors to make the painting quite sharp and vivid. The painting’s background is very light,
whereas the top of the flower features a dark shadow. Additionally, the painting’s bottom is made entirely in light with no harsh dark shadows.
Some critics suggest that O’Keeffe did this to indicate that the flower is dying.' 
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\MadonnainMeadow.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Renaissance' 
WHERE ArtId = 29;

INSERT INTO ArtUser
Values(11,29)


INSERT INTO Art(Title,Description,FeedbackFormFeedbackFromId,Discriminator,Image) 
SELECT 'The Sistine Madonna','The pictorial content of the painting is limited to a man who appears to have just shot himself—still
holding the gun while slouched on a bed—and a few pieces of furniture. Manet has removed the trappings of earlier depictions of suicide, 
and provided next to no narrative content or "moralizing tendency". Ulrike Ilg associates the painting with the realism of Gustave Courbet, 
noting that Courbet also used a depiction of death in his Burial at Ornans (1849–50), a work that Courbet later described as the beginning of 
his new artistic approach.'
,3,'VisualArt', BulkColumn 
FROM Openrowset( Bulk 'C:\Users\zelal\Pictures\pictures\TheSistineMadonna.jpg', Single_Blob) as BulkColumn;

UPDATE Art
SET Genre = 'Renaissance' 
WHERE ArtId = 30;

INSERT INTO ArtUser
Values(11,30)
