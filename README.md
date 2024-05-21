Please ensure that your display's DPI scaling is <= 125% before attempting use (For OOD only)

Link to Luna:
https://i524441.luna.fhict.nl/

Credentials that can be used:
In order -> Username, Email, Password, FirstName, LastName

('john_doe', 'john.doe@example.com', 'password123', 'John', 'Doe'),
('jane_smith', 'jane.smith@example.com', 'password456', 'Jane', 'Smith'),
('alice_johnson', 'alice.johnson@example.com', 'password789', 'Alice', 'Johnson'),
('bob_brown', 'bob.brown@example.com', 'passwordabc', 'Bob', 'Brown'),
('emily_davis', 'emily.davis@example.com', 'passworddef', 'Emily', 'Davis');
('georgitin', 'georgi.tinchev.124@gmail.com, 'e9999619', 'Georgi', 'Tinchev');

Link to Repo:
https://git.fhict.nl/I524441/individual-project-sem2

Discussed my WAD Stream Sage website progression so far. 
Positives:
- Movie fetching is per ID now, without exposing information in the front-end.
- Authentication & Cookies & Remember me works well.
- Site layout and structure is present.
- Auth DTOs and proper separation & usage of models.
- DB design and layer design.

Points for improvement:
- Authentication calls do not resolve in 1 call, but several calls to other layers are made for it.
- Interfaces & Dependency Inversion is not present as of today, hence the Unit Tests can't be seen.
- Edge scenarios for objects fetches within Models have to be addressed.
- Web Controller should not store user session info, as Razor Pages handle it for us.
- Logout should not do POST requests.
- Repeat password for example can be handled within the Auth DTOs.

I will make sure to work towards the LOs and address all of the above concerns & get ready to prove a good site product by the time for the last feedback session.


