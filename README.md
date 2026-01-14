
---

# 🍎 Fruit Basket – Jeu d’Addition (Unity)

## 📘 Description du projet

**Fruit Basket** est un mini-jeu éducatif développé avec **Unity**, destiné à l’apprentissage de l’addition de manière ludique et interactive.

Le joueur doit glisser des fruits dans un panier.
À chaque fruit ajouté, le compteur augmente pour afficher le nombre total de fruits dans le panier.

Ce projet a été réalisé dans un cadre pédagogique afin de faciliter la compréhension des opérations mathématiques de base.

---

## 🎯 Objectifs pédagogiques

* Comprendre le principe de l’addition
* Associer une action concrète (ajouter un fruit) à un calcul
* Développer la logique et la coordination
* Découvrir les bases du développement de jeux avec Unity et C#

---

## 🕹️ Fonctionnalités

* 🌳 Scène 3D avec environnement (Asset Store)
* 🍎 Fruits déplaçables à la souris (Drag & Drop)
* 🧺 Panier interactif avec détection automatique
* ➕ Compteur d’addition dynamique

  * Exemple : `Fruits : 0 → 1 → 2 → 3 …`
* 🔁 Bouton **Restart** pour recommencer la partie
* 🎨 Interface simple et claire (UI + TextMeshPro)

---

## 🛠️ Technologies utilisées

* **Unity** (version recommandée : 2021 LTS ou plus)
* **C#**
* **TextMeshPro**
* **Assets 3D** (fruits, panier, environnement)

---

## 📂 Structure du projet

```
Assets/
│
├── Scripts/
│   ├── DragObject.cs        // Déplacement des fruits à la souris
│   ├── BasketSimple.cs     // Gestion de l’addition et du score
│   └── RestartGame.cs      // Redémarrage du jeu
│
├── Scenes/
│   └── MainScene.unity
│
├── UI/
│   └── ScoreText (TextMeshPro)
│
└── Assets3D/
    ├── Fruits
    ├── Basket
    └── Environment
```

---

## ▶️ Comment jouer

1. Lancer le jeu (**Play**)
2. Observer le score initial : `Fruits : 0`
3. Glisser un fruit dans le panier
4. Le compteur augmente automatiquement de **+1**
5. Répéter l’action pour ajouter d’autres fruits
6. Cliquer sur **Restart** pour recommencer

---

## 🔧 Installation

1. Installer **Unity Hub**
2. Créer un nouveau projet 3D
3. Importer les assets et les scripts
4. Ouvrir la scène principale `MainScene.unity`
5. Cliquer sur **Play**

---

## 👩‍🎓 Réalisé par

* **HASSAOUI Aya**
* **ETTOUYJER Yassmine**

Projet réalisé dans le cadre d’un travail académique / projet pédagogique.

---

