# ASDsense
This is a game developed in unity 3-D and aims to make people view the world from the eyes of an autistic person.

The presentation link:
https://docs.google.com/presentation/d/1VIMT_zOImYptKoy6Crhl7x9wOZjkImpSUxhidvDrXd4/edit#slide=id.p


To Do List
1.) Scoring:= constant * (distance)^0.5  OR  constant * (distance in between two points)
2.) Life = 100 - (lt) + (lg) where
    lt = {
            80 if obstacle is vehicle
            50 if obstacle is person/pole/tree
            0.4*(time of sudden light)
          }
    lg = {
            60/(time taken to solve some puzzle)
          }
          
 3.) Add some z distance between consecutive spawning obstacles to faciitate quick maneuvering.
 
 4.) Add an irritating sound track which plays continuously(or at some points randomly with probability 0.75).
 
 5.) The sudden light can be made at probability 0.5 and space must be entered, say 10 times before it fades.
