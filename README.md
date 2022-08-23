# MarvelCinematicUniversiveTriviaGame

A client-server project that is a command line interface program that uses object oriented programming principles, conditional logic, and error checking for a user to take a 10 question trivia game on a specific MCU movie or televison show. The User is able to navigate the menu screen and test their knowledge on any MCU movie or television show. 

A Movdel View Controller (MVC) pattern is then used to send information and pull information from the SQL Database that is used to save scores for each game that is completed. I am using RestSharp to communiticate to the server side. Then once on the server side, I am using a DAO pattern to insert and pull information into and out of the SQL Database. 

I also used StreamWriter and StreamReader to create an audit log of every game played and implemented a secret input to display the log. 

Features fo the project:
  - A user can create an account and log back in
  - There are over 20 trivia games that can be played
  - A user's score is saved after each game is completed
  - A user can view all of there scores
  - A user can view all of the scores for a specific game
    - This includes their score as well as other user's scores

Future functions: 
  - A user can see there most recent score
  - A user can see there highest score for a specific game

Completed Trivia games: 
  1. Iron Man
  2. The Incredible Hulk 
  3. Iron Man 2
  4. Thor
  5. Captain America The First Avenger
  6. The Avengers
  7. Iron Man 3
  8. Thor: The Dark World
  9. Captain America The Winter Soldier
  10. Guardians of the Galaxy
  11. Avengers Age Of Ultron
  12. Ant-Man
  13. Captain America Civil War
  14. Doctor Strange
  15. Guardians of the Galaxy Vol. 2
  16. Spider-Man: Homecoming
  17. Thor: Ragnarok
  18. Black Panther
  19. Avengers: Infinity War
  20. Ant-Man and the Wasp
  21. Captain Marvel
  22. Avengers: EndGame
