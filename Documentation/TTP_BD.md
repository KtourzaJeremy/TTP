# Trouve ton pote - Base de données

## Table User

Cette table contient tous les attributs nécessaires
pour définir un utilisateur sur le site.
Base de données créée avec [dbdesigner](dbdesigner.net).

* Le mail de l'utilisateur est également son login
* Le niveau utilisateur représente ses droits sur le site (0 = administrateur, 1 = utilisateur).
* Les photos seront stockées dans la BD sous forme de liens.

## Table Event

* LocEvt représente la location de l'évènement
* EtatEvt: 0 = Ouvert; 1 = Fermé
