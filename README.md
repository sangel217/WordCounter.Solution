# Word Counter

#### C# Independent Project for Epicodus, 04.26.2019

#### By Sarah Angel

## Description

This program accepts a word and sentence from a user. The program then checks the sentence for the frequency of the word. It only checks for full word matches only.

## Specs

The program accepts a word as a string. I choose this as the simplest spec because I want to set the word as an object that can then be referenced later.
  * Input: hello
  * Output: hello

The program accepts a sentence as a string. I choose this as the next simplest spec because, again, I want to set the sentence as another object that can be referenced later.
  * Input: Hello, my name is Sarah.
  * Output: Hello my name is Sarah.

The program standardizes the word and sentence to be lower case. I choose this spec so that it would be easier to compare the word and sentence.
  * Input word: Hello ; Input sentence: Hello world.
  * Output word: hello ; Output sentence: hello world.

The program will split the string sentence into a string array with each word as a string element. I choose this spec so that I could compare the input word to the individual words in the input sentence.
  * Input sentence: hello world.
  * Output sentence: "hello", "world"

The program will compare the input word with the sentence word array. I choose this spec so that the program can compare the instances of the input word that matches directly with a word in the sentence.
  * Input word: hello ; Input sentence: hello world
  * Output: 1
