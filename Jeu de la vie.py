from os import name, system
from time import sleep
from random import randint



def init_matrix(rows_count, columns_count):
    return [ [ randint(0, 1)
            for x in range(columns_count) ] 
            for y in range(rows_count) ]



def count_neighbors(matrix, y, x):
    rows_count = len(matrix)
    columns_count = len(matrix[0])
    neighbors = 0
    for y_gap in range(-1, 2):
        for x_gap in range(-1, 2):
            new_y = y_gap + y
            new_x = x_gap + x
            if new_y >= 0 and new_y < rows_count and \
               new_x >= 0 and new_x < columns_count:
                neighbors += matrix[new_y][new_x]
    return neighbors - matrix[y][x]



def next_generation(matrix):
    rows_count = len(matrix)
    columns_count = len(matrix[0])
    fake_matrix = init_matrix(rows_count, columns_count)
    for y in range(rows_count):
        for x in range(columns_count):
            new_state = None
            neighbors = count_neighbors(matrix, y, x)
            if neighbors < 2 or neighbors > 3: new_state = 0
            elif neighbors == 2: new_state = matrix[y][x]
            elif neighbors == 3: new_state = 1
            fake_matrix[y][x] = new_state
    return fake_matrix



def draw_matrix(matrix):
    clear_screen()
    for rows in matrix:
        for cell in rows:
            print("█" if cell == 1 else " ", end = "")
        print()



def clear_screen():
    if name == "nt": system("cls")
    else: system("clear")


    
def start_game(rows_count, columns_count):
    matrix = init_matrix(rows_count, columns_count)
    while True:
        matrix = next_generation(matrix)
        draw_matrix(matrix)
        sleep(.1)



start_game(30, 30)