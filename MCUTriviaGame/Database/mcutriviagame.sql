USE master
GO

IF DB_ID('mcutriviagame') IS NOT NULL
BEGIN
	ALTER DATABASE mcutriviagame SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE mcutriviagame;
END

CREATE DATABASE mcutriviagame
GO

USE mcutriviagame
GO

CREATE TABLE mcutriviagame_user (
	user_id int IDENTITY(1001,1) NOT NULL,
	username varchar(50) NOT NULL,
	password_hash varchar(200) NOT NULL,
	salt varchar(200) NOT NULL,
	CONSTRAINT PK_user PRIMARY KEY (user_id),
	CONSTRAINT UQ_username UNIQUE (username)
)

CREATE TABLE account (
	account_id int IDENTITY(2001,1) NOT NULL,
	user_id int NOT NULL,
	CONSTRAINT PK_account PRIMARY KEY (account_id),
	CONSTRAINT FK_account_mcutriviagame_user FOREIGN KEY (user_id) REFERENCES mcutriviagame_user (user_id)
)

Create Table mcu_movies(
	movie_name varchar(50) NOT NULL, 
	phase int NOT NULL, 
	CONSTRAINT PK_mcu_movies PRIMARY KEY (movie_name)
)

Create Table user_scores(
	game_number int IDENTITY(1, 1) NOT NULL,
	username varchar(50) NOT NULL, 
	movie_name varchar(50) Not Null, 
	score int Not Null,  
	CONSTRAINT PK_user_scores PRIMARY KEY (game_number),
	CONSTRAINT FK_user_scores_mcutriviagame_user FOREIGN KEY (username) REFERENCES mcutriviagame_user (username),
	CONSTRAINT FK_user_scores_mcu_movies FOREIGN KEY (movie_name) REFERENCES mcu_movies (movie_name), 
)

CREATE TABLE user_most_recent_score(
	username varchar(50) Not Null,
	movie_name varchar(50), 
	score int, 
	CONSTRAINT PK_user_most_recent_score PRIMARY KEY (username), 
)

Create TABLE reviews(
	review_id int IDENTITY (1, 1) NOT NULL, 
	username varchar(50) NOT NULL, 
	movie_name varchar(50) NOT NULL, 
	review varchar(500) NOT NULL,
	CONSTRAINT PK_reviews PRIMARY KEY (review_id),
	CONSTRAINT FK_reviews_mcutriviagame_user FOREIGN KEY (username) REFERENCES mcutriviagame_user (username), 
	CONSTRAINT FK_reviews_mcu_movies FOREIGN KEY (movie_name) REFERENCES mcu_movies (movie_name),
)

Create TABLE likes(
	movie_name varchar(50) Not Null, 
	liked int Not Null, 
	disliked int Not Null,
	CONSTRAINT PK_likes PRIMARY KEY (movie_name)
)

Select * FROM user_scores; 
Select * FROM mcu_movies;
Select * FROM mcutriviagame_user;
SELECT * FROM user_most_recent_score; 
SELECT * FROM reviews; 
SELECT * FROM likes; 

INSERT INTO mcu_movies (movie_name, phase)
VALUES ('Iron Man', 1), 
('The Incredible Hulk', 1), 
('Iron Man 2', 1),
('Thor', 1), 
('Captain America: The First Avenger', 1),
('The Avengers', 1), 
('Iron Man 3', 2), 
('Thor: The Dark World', 2), 
('Captain America: The Winter Soldier', 2), 
('Guardians of the Galaxy', 2), 
('Avengers: Age of Ultron', 2), 
('Ant-Man', 2), 
('Captain America: Civil War', 3), 
('Doctor Strange', 3), 
('Guardians of the Galaxy Vol. 2', 3), 
('Spider-Man: Homecoming', 3),
('Thor: Ragnarok', 3), 
('Black Panther', 3), 
('Avengers: Infinity War', 3),
('Ant-Man and the Wasp', 3), 
('Captain Marvel', 3), 
('Avengers: Endgame', 3),
('Spider-Man: Far From Home', 3),
('Black Widow', 4), 
('Shang-Chi and the Legend of the Ten Rings', 4), 
('Eternals', 4), 
('Spider-Man: No Way Home', 4), 
('Doctor Strange in the Multiverse of Madness', 4), 
('Thor: Love and Thunder', 4), 
('Black Panther: Wakanda Forever', 4)

INSERT INTO likes (movie_name, liked, disliked)
VALUES ('Iron Man', 0, 0), 
('The Incredible Hulk', 0, 0), 
('Iron Man 2', 0, 0),
('Thor', 0, 0), 
('Captain America: The First Avenger', 0, 0),
('The Avengers', 0, 0), 
('Iron Man 3', 0, 0), 
('Thor: The Dark World', 0, 0), 
('Captain America: The Winter Soldier', 0, 0), 
('Guardians of the Galaxy', 0, 0), 
('Avengers: Age of Ultron', 0, 0), 
('Ant-Man', 0, 0), 
('Captain America: Civil War', 0, 0), 
('Doctor Strange', 0, 0), 
('Guardians of the Galaxy Vol. 2', 0, 0), 
('Spider-Man: Homecoming', 0, 0),
('Thor: Ragnarok', 0, 0), 
('Black Panther', 0, 0), 
('Avengers: Infinity War', 0, 0),
('Ant-Man and the Wasp', 0, 0), 
('Captain Marvel', 0, 0), 
('Avengers: Endgame', 0, 0),
('Spider-Man: Far From Home', 0, 0),
('Black Widow', 0, 0), 
('Shang-Chi and the Legend of the Ten Rings', 0, 0), 
('Eternals', 0, 0), 
('Spider-Man: No Way Home', 0, 0), 
('Doctor Strange in the Multiverse of Madness', 0, 0), 
('Thor: Love and Thunder', 0, 0), 
('Black Panther: Wakanda Forever', 0, 0)