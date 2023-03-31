# Challenge One
## Way One
1. I create two projects, the first is the EFUniveristyDomain which has the DB Tables definitios on it. I have to install `Microsoft.EntityFrameworkCore.SqlServer` library. The other project is the EFUniversityData which has the UniversityContext.
   

2. I create the class PersonBaseDomain, which is an abstract class, and has the property ID, LastName, FirstMidName so student and Instructor and use that properties and add more. 

3. In the EFUniveristyDomain project I create the following classes based on the DB tables.
      * Student
      * Instructor
      * OfficeAssignment
      * Department
      * Course
      * Enrollment
      * CourseAssignment
  
4. Then I added the reference from the EFUniveristyDomain project to the EFUniveristyData project.

5. Then in the EFUniveristyData project I create the UnivesityContext.cs class.
   * I reference EntityFrameworkDomain and inherit DbContext
   * Then I override the method OnConfiguring and add the DB Connetion, to the local server and this Connection String: `"Data Source=LAPTOP-KAP3NP1H; Initial Catalog=UniversityContext; persist security info=True; Integrated Security=SSPI;"` and also add some console logging to see the querys executed
 * Then I override the method OnModelCreating and add some restrictions. Like index and varchar sizes.
 * Then I seed some data into the tables.
 * Then I add the DBSet fot the classes defined in the EFUniveristyDomain

With this I got the University Context. Then in the Nuget Console I can add-migration and then update-database.




## Way Two
I can create the context of the DB with a reverse engineer of the database. Using the next command:
`Scaffold-Dbcontext -provider Microsoft.EntityFrameworkCore.SqlServer -connection "Data Source=LAPTOP-KAP3NP1H; Initial Catalog=University; persist security info=True; Integrated Security=SSPI;"`

This will create the table classes and the University context. 
![UniversityContextTwo](C1W2.png)

# Challenge Two and Three
This is the DB diagram that is going to be implemented.     

![Diagram](../img/DBDiagram.png)