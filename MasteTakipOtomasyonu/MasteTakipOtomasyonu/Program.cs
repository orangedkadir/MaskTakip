// See https://aka.ms/new-console-template for more information
using Business.Concrate;
using Entities.Concrate;

Console.WriteLine("Hello, World!");
Person kadir = new Person { FirstName= "KADİR",LastName="TOPCU",NationalIdentity=123,DateOfBirth= 1990};
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(kadir);