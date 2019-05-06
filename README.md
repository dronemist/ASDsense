# ASDsense
This is a game developed in unity 3-D and aims to make people view the world from the eyes of an autistic person.

The presentation link:
https://docs.google.com/presentation/d/1VIMT_zOImYptKoy6Crhl7x9wOZjkImpSUxhidvDrXd4/edit#slide=id.p


To Do List

1) Add a canvas to ASD_game_scene and Normal_game_scene, for pause menu, enable disable it with esc and give and option to restart or go to main menu
2) Instead of Volume show High score in Options menu(in main menu).To access highscore use the following syntax:-
``
high_score.text = "High Score: " + PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
``
