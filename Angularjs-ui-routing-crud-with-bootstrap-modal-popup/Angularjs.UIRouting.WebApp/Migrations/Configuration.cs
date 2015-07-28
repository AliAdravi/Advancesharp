namespace Angularjs.UIRouting.WebApp.Migrations
{
    using Angularjs.UIRouting.WebApp.DataAccessLayer;
    using Angularjs.UIRouting.WebApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataContext context)
        {
            var customers = new List<Customer>{
                new Customer { CustomerId = 1, FullName = "Alejandra Camino", Address = "Gran V�a, 1", City = "Madrid", ZipCode = "28001", Country = "Spain", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 2, FullName = "Alexander Feuer", Address = "Heerstr. 22", City = "Leipzig", ZipCode = "04179", Country = "Germany", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 3, FullName = "Ana Trujillo", Address = "Avda. de la Constituci�n 2222", City = "M�xico D.F.", ZipCode = "05021", Country = "Mexico", Image = "/CustomerImages/image-3.jpg" },
                new Customer { CustomerId = 4, FullName = "Anabela Domingues", Address = "Av. In�s de Castro, 414", City = "Sao Paulo", ZipCode = "05634-030", Country = "Brazil", Image = "/CustomerImages/image-4.jpg" },
                new Customer { CustomerId = 5, FullName = "Andr� Fonseca", Address = "Av. Brasil, 442", City = "Campinas", ZipCode = "04876-786", Country = "Brazil", Image = "/CustomerImages/image-5.jpg" },
                new Customer { CustomerId = 6, FullName = "Ann Devon", Address = "35 King George", City = "London", ZipCode = "WX3 6FW", Country = "UK", Image = "/CustomerImages/image-6.jpg" },
                new Customer { CustomerId = 7, FullName = "Annette Roulet", Address = "1 rue Alsace-Lorraine", City = "Toulouse", ZipCode = "31000", Country = "France", Image = "/CustomerImages/image-7.jpg" },
                new Customer { CustomerId = 8, FullName = "Antonio Moreno", Address = "Mataderos  2312", City = "M�xico D.F.", ZipCode = "05023", Country = "Mexico", Image = "/CustomerImages/image-8.jpg" },
                new Customer { CustomerId = 9, FullName = "Aria Cruz", Address = "Rua Or�s, 92", City = "Sao Paulo", ZipCode = "05442-030", Country = "Brazil", Image = "/CustomerImages/image-9.jpg" },
                new Customer { CustomerId = 10, FullName = "Art Braunschweiger", Address = "P.O. Box 555", City = "Lander", ZipCode = "82520", Country = "USA", Image = "/CustomerImages/image-10.jpg" },
                new Customer { CustomerId = 11, FullName = "Bernardo Batista", Address = "Rua da Panificadora, 12", City = "Rio de Janeiro", ZipCode = "02389-673", Country = "Brazil", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 12, FullName = "Carine Schmitt", Address = "54, rue Royale", City = "Nantes", ZipCode = "44000", Country = "France", Image = "/CustomerImages/image-6.jpg" },
                new Customer { CustomerId = 13, FullName = "Carlos Gonz�lez", Address = "Carrera 52 con Ave. Bol�var #65-98 Llano Largo", City = "Barquisimeto", ZipCode = "3508", Country = "Venezuela", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 14, FullName = "Carlos Hern�ndez", Address = "Carrera 22 con Ave. Carlos Soublette #8-35", City = "San Crist�bal", ZipCode = "5022", Country = "Venezuela", Image = "/CustomerImages/image-7.jpg" },
                new Customer { CustomerId = 15, FullName = "Catherine Dewey", Address = "Rue Joseph-Bens 532", City = "Bruxelles", ZipCode = "B-1180", Country = "Belgium", Image = "/CustomerImages/image-5.jpg" },
                new Customer { CustomerId = 16, FullName = "Christina Berglund", Address = "Berguvsv�gen  8", City = "Lule�", ZipCode = "S-958 22", Country = "Sweden", Image = "/CustomerImages/image-8.jpg" },
                new Customer { CustomerId = 17, FullName = "Daniel Tonini", Address = "67, avenue de l'Europe", City = "Versailles", ZipCode = "78000", Country = "France", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 18, FullName = "Diego Roel", Address = "C/ Moralzarzal, 86", City = "Madrid", ZipCode = "28034", Country = "Spain", Image = "/CustomerImages/image-9.jpg" },
                new Customer { CustomerId = 19, FullName = "Dominique Perrier", Address = "25, rue Lauriston", City = "Paris", ZipCode = "75016", Country = "France", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 20, FullName = "Eduardo Saavedra", Address = "Rambla de Catalu�a, 23", City = "Barcelona", ZipCode = "08022", Country = "Spain", Image = "/CustomerImages/image-10.jpg" },
                new Customer { CustomerId = 21, FullName = "Elizabeth Brown", Address = "Berkeley Gardens 12  Brewery", City = "London", ZipCode = "WX1 6LT", Country = "UK", Image = "/CustomerImages/image-7.jpg" },
                new Customer { CustomerId = 22, FullName = "Elizabeth Lincoln", Address = "23 Tsawassen Blvd.", City = "Tsawassen", ZipCode = "T2F 8M4", Country = "Canada", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 23, FullName = "Felipe Izquierdo", Address = "Ave. 5 de Mayo Porlamar", City = "I. de Margarita", ZipCode = "4980", Country = "Venezuela", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 24, FullName = "Fran Wilson", Address = "89 Chiaroscuro Rd.", City = "Portland", ZipCode = "97219", Country = "USA", Image = "/CustomerImages/image-8.jpg" },
                new Customer { CustomerId = 25, FullName = "Francisco Chang", Address = "Sierras de Granada 9993", City = "M�xico D.F.", ZipCode = "05022", Country = "Mexico", Image = "/CustomerImages/image-5.jpg" },
                new Customer { CustomerId = 26, FullName = "Fr�d�rique Citeaux", Address = "24, place Kl�ber", City = "Strasbourg", ZipCode = "67000", Country = "France", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 27, FullName = "Georg Pipps", Address = "Geislweg 14", City = "Salzburg", ZipCode = "5020", Country = "Austria", Image = "/CustomerImages/image-9.jpg" },
                new Customer { CustomerId = 28, FullName = "Giovanni Rovelli", Address = "Via Ludovico il Moro 22", City = "Bergamo", ZipCode = "24100", Country = "Italy", Image = "/CustomerImages/image-7.jpg" },
                new Customer { CustomerId = 29, FullName = "Guillermo Fern�ndez", Address = "Calle Dr. Jorge Cash 321", City = "M�xico D.F.", ZipCode = "05033", Country = "Mexico", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 30, FullName = "Hanna Moos", Address = "Forsterstr. 57", City = "Mannheim", ZipCode = "68306", Country = "Germany", Image = "/CustomerImages/image-10.jpg" },
                new Customer { CustomerId = 31, FullName = "Hari Kumar", Address = "90 Wadhurst Rd.", City = "London", ZipCode = "OX15 4NB", Country = "UK", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 32, FullName = "Helen Bennett", Address = "Garden House Crowther Way", City = "Cowes", ZipCode = "PO31 7PJ", Country = "UK", Image = "/CustomerImages/image-8.jpg" },
                new Customer { CustomerId = 33, FullName = "Helvetius Nagy", Address = "722 DaVinci Blvd.", City = "Kirkland", ZipCode = "98034", Country = "USA", Image = "/CustomerImages/image-3.jpg" },
                new Customer { CustomerId = 34, FullName = "Henriette Pfalzheim", Address = "Mehrheimerstr. 369", City = "K�ln", ZipCode = "50739", Country = "Germany", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 35, FullName = "Horst Kloss", Address = "Taucherstra�e 10", City = "Cunewalde", ZipCode = "01307", Country = "Germany", Image = "/CustomerImages/image-7.jpg" },
                new Customer { CustomerId = 36, FullName = "Howard Snyder", Address = "2732 Baker Blvd.", City = "Eugene", ZipCode = "97403", Country = "USA", Image = "/CustomerImages/image-9.jpg" },
                new Customer { CustomerId = 37, FullName = "Isabel de Castro", Address = "Estrada da sa�de n. 58", City = "Lisboa", ZipCode = "1756", Country = "Portugal", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 38, FullName = "Jaime Yorres", Address = "87 Polk St. Suite 5", City = "San Francisco", ZipCode = "94117", Country = "USA", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 39, FullName = "Janete Limeira", Address = "Av. Copacabana, 267", City = "Rio de Janeiro", ZipCode = "02389-890", Country = "Brazil", Image = "/CustomerImages/image-3.jpg" },
                new Customer { CustomerId = 40, FullName = "Janine Labrune", Address = "67, rue des Cinquante Otages", City = "Nantes", ZipCode = "44000", Country = "France", Image = "/CustomerImages/image-10.jpg" },
                new Customer { CustomerId = 41, FullName = "Jean Fresni�re", Address = "43 rue St. Laurent", City = "Montr�al", ZipCode = "H1J 1C3", Country = "Canada", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 42, FullName = "John Steel", Address = "12 Orchestra Terrace", City = "Walla Walla", ZipCode = "99362", Country = "USA", Image = "/CustomerImages/image-7.jpg" },
                new Customer { CustomerId = 43, FullName = "Jonas Bergulfsen", Address = "Erling Skakkes gate 78", City = "Stavern", ZipCode = "4110", Country = "Norway", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 44, FullName = "Jose Pavarotti", Address = "187 Suffolk Ln.", City = "Boise", ZipCode = "83720", Country = "USA", Image = "/CustomerImages/image-4.jpg" },
                new Customer { CustomerId = 45, FullName = "Jos� Pedro Freyre", Address = "C/ Romero, 33", City = "Sevilla", ZipCode = "41101", Country = "Spain", Image = "/CustomerImages/image-9.jpg" },
                new Customer { CustomerId = 46, FullName = "Jytte Petersen", Address = "Vinb�ltet 34", City = "Kobenhavn", ZipCode = "1734", Country = "Denmark", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 47, FullName = "Karin Josephs", Address = "Luisenstr. 48", City = "M�nster", ZipCode = "44087", Country = "Germany", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 48, FullName = "Karl Jablonski", Address = "305 - 14th Ave. S. Suite 3B", City = "Seattle", ZipCode = "98128", Country = "USA", Image = "/CustomerImages/image-8.jpg" },
                new Customer { CustomerId = 49, FullName = "Laurence Lebihan", Address = "12, rue des Bouchers", City = "Marseille", ZipCode = "13008", Country = "France", Image = "/CustomerImages/image-7.jpg" },
                new Customer { CustomerId = 50, FullName = "Lino Rodriguez", Address = "Jardim das rosas n. 32", City = "Lisboa", ZipCode = "1675", Country = "Portugal", Image = "/CustomerImages/image-10.jpg" },
                new Customer { CustomerId = 51, FullName = "Liu Wong", Address = "55 Grizzly Peak Rd.", City = "Butte", ZipCode = "59801", Country = "USA", Image = "/CustomerImages/image-3.jpg" },
                new Customer { CustomerId = 52, FullName = "Liz Nixon", Address = "89 Jefferson Way Suite 2", City = "Portland", ZipCode = "97201", Country = "USA", Image = "/CustomerImages/image-4.jpg" },
                new Customer { CustomerId = 53, FullName = "L�cia Carvalho", Address = "Alameda dos Can�rios, 891", City = "Sao Paulo", ZipCode = "05487-020", Country = "Brazil", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 54, FullName = "Manuel Pereira", Address = "5� Ave. Los Palos Grandes", City = "Caracas", ZipCode = "1081", Country = "Venezuela", Image = "/CustomerImages/image-9.jpg" },
                new Customer { CustomerId = 55, FullName = "Maria Anders", Address = "Obere Str. 57", City = "Berlin", ZipCode = "12209", Country = "Germany", Image = "/CustomerImages/image-5.jpg" },
                new Customer { CustomerId = 56, FullName = "Maria Larsson", Address = "�kergatan 24", City = "Br�cke", ZipCode = "S-844 67", Country = "Sweden", Image = "/CustomerImages/image-8.jpg" },
                new Customer { CustomerId = 57, FullName = "Marie Bertrand", Address = "265, boulevard Charonne", City = "Paris", ZipCode = "75012", Country = "France", Image = "/CustomerImages/image-3.jpg" },
                new Customer { CustomerId = 58, FullName = "Mario Pontes", Address = "Rua do Pa�o, 67", City = "Rio de Janeiro", ZipCode = "05454-876", Country = "Brazil", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 59, FullName = "Mart�n Sommer", Address = "C/ Araquil, 67", City = "Madrid", ZipCode = "28023", Country = "Spain", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 60, FullName = "Martine Ranc�", Address = "184, chauss�e de Tournai", City = "Lille", ZipCode = "59000", Country = "France", Image = "/CustomerImages/image-10.jpg" },
                new Customer { CustomerId = 61, FullName = "Mary Saveley", Address = "2, rue du Commerce", City = "Lyon", ZipCode = "69004", Country = "France", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 62, FullName = "Matti Karttunen", Address = "Keskuskatu 45", City = "Helsinki", ZipCode = "21240", Country = "Finland", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 63, FullName = "Maurizio Moroni", Address = "Strada Provinciale 124", City = "Reggio Emilia", ZipCode = "42100", Country = "Italy", Image = "/CustomerImages/image-9.jpg" },
                new Customer { CustomerId = 64, FullName = "Michael Holz", Address = "Grenzacherweg 237", City = "Gen�ve", ZipCode = "1203", Country = "Switzerland", Image = "/CustomerImages/image-8.jpg" },
                new Customer { CustomerId = 65, FullName = "Miguel Angel Paolino", Address = "Avda. Azteca 123", City = "M�xico D.F.", ZipCode = "05033", Country = "Mexico", Image = "/CustomerImages/image-5.jpg" },
                new Customer { CustomerId = 66, FullName = "Palle Ibsen", Address = "Smagsloget 45", City = "�rhus", ZipCode = "8200", Country = "Denmark", Image = "/CustomerImages/image-6.jpg" },
                new Customer { CustomerId = 67, FullName = "Paolo Accorti", Address = "Via Monte Bianco 34", City = "Torino", ZipCode = "10100", Country = "Italy", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 68, FullName = "Pascale Cartrain", Address = "Boulevard Tirou, 255", City = "Charleroi", ZipCode = "B-6000", Country = "Belgium", Image = "/CustomerImages/image-4.jpg" },
                new Customer { CustomerId = 69, FullName = "Patricio Simpson", Address = "Cerrito 333", City = "Buenos Aires", ZipCode = "1010", Country = "Argentina", Image = "/CustomerImages/image-3.jpg" },
                new Customer { CustomerId = 70, FullName = "Paul Henriot", Address = "59 rue de l'Abbaye", City = "Reims", ZipCode = "51100", Country = "France", Image = "/CustomerImages/image-10.jpg" },
                new Customer { CustomerId = 71, FullName = "Paula Parente", Address = "Rua do Mercado, 12", City = "Resende", ZipCode = "08737-363", Country = "Brazil", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 72, FullName = "Paula Wilson", Address = "2817 Milton Dr.", City = "Albuquerque", ZipCode = "87110", Country = "USA", Image = "/CustomerImages/image-9.jpg" },
                new Customer { CustomerId = 73, FullName = "Pedro Afonso", Address = "Av. dos Lus�adas, 23", City = "Sao Paulo", ZipCode = "05432-043", Country = "Brazil", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 74, FullName = "Peter Franken", Address = "Berliner Platz 43", City = "M�nchen", ZipCode = "80805", Country = "Germany", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 75, FullName = "Philip Cramer", Address = "Maubelstr. 90", City = "Brandenburg", ZipCode = "14776", Country = "Germany", Image = "/CustomerImages/image-5.jpg" },
                new Customer { CustomerId = 76, FullName = "Pirkko Koskitalo", Address = "Torikatu 38", City = "Oulu", ZipCode = "90110", Country = "Finland", Image = "/CustomerImages/image-4.jpg" },
                new Customer { CustomerId = 77, FullName = "Renate Messner", Address = "Magazinweg 7", City = "Frankfurt a.M.", ZipCode = "60528", Country = "Germany", Image = "/CustomerImages/image-7.jpg" },
                new Customer { CustomerId = 78, FullName = "Rene Phillips", Address = "2743 Bering St.", City = "Anchorage", ZipCode = "99508", Country = "USA", Image = "/CustomerImages/image-6.jpg" },
                new Customer { CustomerId = 79, FullName = "Rita M�ller", Address = "Adenauerallee 900", City = "Stuttgart", ZipCode = "70563", Country = "Germany", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 80, FullName = "Roland Mendel", Address = "Kirchgasse 6", City = "Graz", ZipCode = "8010", Country = "Austria", Image = "/CustomerImages/image-10.jpg" },
                new Customer { CustomerId = 81, FullName = "Sergio Guti�rrez", Address = "Av. del Libertador 900", City = "Buenos Aires", ZipCode = "1010", Country = "Argentina", Image = "/CustomerImages/image-9.jpg" },
                new Customer { CustomerId = 82, FullName = "Simon Crowther", Address = "South House 300 Queensbridge", City = "London", ZipCode = "SW7 1RZ", Country = "UK", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 83, FullName = "Sven Ottlieb", Address = "Walserweg 21", City = "Aachen", ZipCode = "52066", Country = "Germany", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 84, FullName = "Thomas Hardy", Address = "120 Hanover Sq.", City = "London", ZipCode = "WA1 1DP", Country = "UK", Image = "/CustomerImages/image-7.jpg" },
                new Customer { CustomerId = 85, FullName = "Victoria Ashworth", Address = "Fauntleroy Circus", City = "London", ZipCode = "EC2 5NT", Country = "UK", Image = "/CustomerImages/image-5.jpg" },
                new Customer { CustomerId = 86, FullName = "Yang Wang", Address = "Hauptstr. 29", City = "Bern", ZipCode = "3012", Country = "Switzerland", Image = "/CustomerImages/image-2.jpg" },
                new Customer { CustomerId = 87, FullName = "Yoshi Latimer", Address = "City Center Plaza 516 Main St.", City = "Elgin", ZipCode = "97827", Country = "USA", Image = "/CustomerImages/image-3.jpg" },
                new Customer { CustomerId = 88, FullName = "Yoshi Tannamuri", Address = "1900 Oak St.", City = "Vancouver", ZipCode = "V3F 2K1", Country = "Canada", Image = "/CustomerImages/image-8.jpg" },
                new Customer { CustomerId = 89, FullName = "Yvonne Moncada", Address = "Ing. Gustavo Moncada 8585 Piso 20-A", City = "Buenos Aires", ZipCode = "1010", Country = "Argentina", Image = "/CustomerImages/image-1.jpg" },
                new Customer { CustomerId = 90, FullName = "Zbyszek Piestrzeniewicz", Address = "ul. Filtrowa 68", City = "Warszawa", ZipCode = "01-012", Country = "Poland", Image = "/CustomerImages/image-10.jpg" }
            };

            customers.ForEach(s => context.Customers.AddOrUpdate(p => p.FullName, s));
            context.SaveChanges();

            var contacts = new List<Contact>
            {
                new Contact  {ContactId =1, CustomerId =1, Phone ="(953) 10956", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =2, CustomerId =2, Phone ="(98) 598 76 54", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =3, CustomerId =3, Phone ="(0)2-953010", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =4, CustomerId =4, Phone ="(11) 555 4640", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =5, CustomerId =5, Phone ="555-8787", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =6, CustomerId =6, Phone ="(514) 555-2955", Fax="(514) 555-2921", Email="someemail@hotmail.com"},
                new Contact  {ContactId =7, CustomerId =7, Phone ="(171) 555-2222", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =8, CustomerId =8, Phone ="(503) 555-9931", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =9, CustomerId =9, Phone ="(12345) 1212", Fax="(12345) 1210", Email="someemail@hotmail.com"},
                new Contact  {ContactId =10, CustomerId =10, Phone ="38.76.98.06", Fax="38.76.98.58", Email="someemail@hotmail.com"},
                new Contact  {ContactId =11, CustomerId =11, Phone ="(0544) 60323", Fax="(0544) 60603", Email="someemail@hotmail.com"},
                new Contact  {ContactId =12, CustomerId =12, Phone ="(089) 6547665", Fax="(089) 6547667", Email="someemail@hotmail.com"},
                new Contact  {ContactId =13, CustomerId =13, Phone ="(1) 03.83.00.68", Fax="(1) 03.83.00.62", Email="someemail@hotmail.com"},
                new Contact  {ContactId =14, CustomerId =14, Phone ="(03) 444-2343", Fax="(03) 444-6588", Email="someemail@hotmail.com"},
                new Contact  {ContactId =15, CustomerId =15, Phone ="(514) 555-9022", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =16, CustomerId =16, Phone ="031-987 65 43", Fax="031-987 65 91", Email="someemail@hotmail.com"},
                new Contact  {ContactId =17, CustomerId =17, Phone ="85.57.00.07", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =18, CustomerId =18, Phone ="(069) 992755", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =19, CustomerId =19, Phone ="(06) 431-7877", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =20, CustomerId =20, Phone ="08-123 45 67", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =21, CustomerId =21, Phone ="43844108", Fax="43844115", Email="someemail@hotmail.com"},
                new Contact  {ContactId =22, CustomerId =22, Phone ="(161) 555-4448", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =23, CustomerId =23, Phone ="(010) 9984510", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =24, CustomerId =24, Phone ="(313) 555-5735", Fax="(313) 555-3349", Email="someemail@hotmail.com"},
                new Contact  {ContactId =25, CustomerId =25, Phone ="(617) 555-3267", Fax="(617) 555-3389", Email="someemail@hotmail.com"},
                new Contact  {ContactId =26, CustomerId =26, Phone ="(100) 555-4822", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =27, CustomerId =27, Phone ="(04721) 8713", Fax="(04721) 8714", Email="someemail@hotmail.com"},
                new Contact  {ContactId =28, CustomerId =28, Phone ="(02) 555-5914", Fax="(02) 555-4873", Email="someemail@hotmail.com"},
                new Contact  {ContactId =29, CustomerId =29, Phone ="(03) 3555-5011", Fax="", Email="someemail@hotmail.com"},
                new Contact  {ContactId =30, CustomerId =3, Phone ="(953) 10956", Fax="", Email="AnaTrujillo@gmail.com"},
                new Contact  {ContactId =31, CustomerId =3, Phone ="555-8787", Fax="", Email="AnaTrujillo@gmail.com"},
                new Contact  {ContactId =32, CustomerId =4, Phone ="555-8787", Fax="", Email="AnabelaDomingues@gmail.com"},
                new Contact  {ContactId =33, CustomerId =4, Phone ="(0544) 60323", Fax="(0544) 60603", Email="AnabelaDomingues@gmail.com"},
                new Contact  {ContactId =34, CustomerId =5, Phone ="555-8787", Fax="", Email="Andr�Fonseca@gmail.com"},
                new Contact  {ContactId =35, CustomerId =5, Phone ="(0544) 60323", Fax="(0544) 60603", Email="Andr�Fonseca@gmail.com"},
                new Contact  {ContactId =36, CustomerId =6, Phone ="(514) 555-9022", Fax="", Email="AnnDevon@gmail.com"},
                new Contact  {ContactId =37, CustomerId =6, Phone ="(010) 9984510", Fax="", Email="AriaCruz@gmail.com"},
                new Contact  {ContactId =38, CustomerId =6, Phone ="85.57.00.07", Fax="", Email="AriaCruz@gmail.com"},
                new Contact  {ContactId =39, CustomerId =6, Phone ="(010) 9984510", Fax="", Email="AriaCruz@gmail.com"},
                new Contact  {ContactId =40, CustomerId =11, Phone ="85.57.00.07", Fax="", Email="BernardoBatista@gmail.com"},
                new Contact  {ContactId =41, CustomerId =11, Phone ="(010) 9984510", Fax="", Email="BernardoBatista@gmail.com"},
                new Contact  {ContactId =42, CustomerId =7, Phone ="85.57.00.07", Fax="", Email="AnnetteRoulet@gmail.com"},
                new Contact  {ContactId =43, CustomerId =7, Phone ="(010) 9984510", Fax="", Email="AnnetteRoulet@gmail.com"},
                new Contact  {ContactId =44, CustomerId =7, Phone ="(12345) 1212", Fax="(12345) 1210", Email="AnnetteRoulet@gmail.com"},
                new Contact  {ContactId =45, CustomerId =7, Phone ="43844108", Fax="43844115", Email="AnnetteRoulet@gmail.com"}
            };

            contacts.ForEach(s => context.Contacts.AddOrUpdate(p => p.CustomerId, s));
            context.SaveChanges();

        }
    }
}
