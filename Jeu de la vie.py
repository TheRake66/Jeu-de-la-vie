from os import name, system
from time import sleep
from random import randint



def creerTNull(nbL, nbC):
    T = [[0 for i in range(nbC)] for j in range(nbL)]
    for i in range(1, len(T)-1):
        for j in range(1, len(T[i])-1):
            T[i][j] = randint(0, 1)
    return T



def nbVoisins(T, l, c):
    nb = 0
    for i in range(-1, 2):
        for j in range(-1, 2):
            nb += T[l+i][c+j]
    return nb - T[l][c]



def nextGeneration(T):
    tempT = creerTNull(len(T), len(T[0]))
    for i in range(1, len(T)-1):
        for j in range(1, len(T[i])-1):
            nb = nbVoisins(T, i, j)
            if nb < 2 or nb > 3: tempT[i][j] = 0
            elif nb == 2: tempT[i][j] = T[i][j]
            elif nb == 3: tempT[i][j] = 1
    return tempT



def afficherT(T):
    effacer()
    for i in T:
        for j in i:
            print("█", end="") if j ==1 else print(" ", end="")
        print()



def effacer():
    if name == "nt": system("cls")
    else: system("clear")


    
def jeuDeLaVie(l, c):
    T = creerTNull(l, c)
    while True:
        T = nextGeneration(T)
        afficherT(T)
        sleep(.001)



jeuDeLaVie(30, 100)