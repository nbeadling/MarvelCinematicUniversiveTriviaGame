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
	date_time datetime, 
	CONSTRAINT PK_user_scores PRIMARY KEY (game_number),
	CONSTRAINT FK_user_scores_mcutriviagame_user FOREIGN KEY (username) REFERENCES mcutriviagame_user (username),
	CONSTRAINT FK_user_scores_mcu_movies FOREIGN KEY (movie_name) REFERENCES mcu_movies (movie_name), 
)



INSERT INTO mcu_movies (movie_name, phase)
VALUES ('Iron Man', 1), 
('The Incredible Hulk', 1), 
('Iron Man 2', 1),
('Thor', 1), 
('Captain America The First Avenger', 1),
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
