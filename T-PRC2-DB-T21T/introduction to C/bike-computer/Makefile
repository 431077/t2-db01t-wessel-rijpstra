NAME=main

FILES= main.c \
		bike_math.c\
		bike_measure.c\
		bike_store.c


HEADER_FILES=*.h

CC=gcc

SYMBOLS=-Wall -Werror -g -pedantic -O0 -std=c99

.PHONY: clean

all: product

product: Makefile $(FILES) $(HEADER_FILES)
	$(CC) $(INC_DIRS) $(SYMBOLS) $(FILES) -o $(NAME)

run: product
	./$(NAME)

clean:
	rm -f $(NAME)
