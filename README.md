# _Word Counter_

#### _A webpage which counts the number of occurrences of a word in a given sentence, 08.11.17_

#### By _**Kaili Nishihira**_

## Description

_The user will input a sentence(s) and then input a word to count. The application will count the number of times the given word appears in the given sentence(s) and display the count back to the user._

|| Behavior  | Input  | Output  |
|---|---|---|---|
|1.| User will enter a one word sentence and a word to count. The inputted word will not appear in the inputted sentence.   | <li>Sentence: "Hello"</li><li>Word to Count: "Hi"</li>  | Word Count: 0   |
|2.| User will enter a multi-word sentence and a word to count. The inputted word will not appear in the inputted sentence.   | <li>Sentence: "Hello there"</li><li>Word to Count: "Hi"</li>  | Word Count: 0   |
|3.| User will enter a sentence and a word to count. Both inputs will be an exact match.  | <li>Sentence: "Hello"</li><li>Word to Count: "Hello"</li>| Word Count: 1  |
|4.| User will enter a sentence and a word to count. The inputted word will be the same as the inputted sentence, but the inputted word will be in lowercase.  | <li>Sentence: "Hello"</li><li>Word to Count: "hello"</li>  | Word Count: 1  |
|5.| User will enter a two word sentence and a word to count. Both words in the inputted sentence will be the same word as the inputted word.  | <li>Sentence: "Hello Hello"</li><li>Word to Count: "hello"</li>  | Word Count: 2  |
|6.| User will enter a multi-word sentence and a word to count. The inputted word will appear once in the inputted sentence.   | <li>Sentence: "Hello there"</li><li>Word to Count: "hello"</li>   | Word Count: 1  |
|7.| User will enter a multi-word sentence and a word to count. The inputted word will appear in the middle of the inputted sentence. | <li>Sentence: "Why hello there."</li><li>Word to Count: "hello"</li> | Word Count: 1 |
|8.| User will enter a multi-word sentence and a word to count. The inputted word will appear multiple times within the inputted sentence.   | <li>Sentence: "You know Dasher and Dancer and Prancer and Vixen, you know Comet and Cupid and Donner and Blitzen."</li><li>Word to Count: "and"  | Word Count: 6 |
|9.| User will enter a multi-word sentence and word to count. The inputted word appears at the end of the inputted sentence with a '.'  | <li>Sentence: "Say hello."</li><li>Word to Count: "hello"</li>   | Word Count: 1  |
|10.| User does not input a sentence or word.  | <li>Sentence: " "</li><li>Word to Count: " "</li> | Word Count: 0  |
|11.| User will enter a sentence and word to count. The inputted word will be a partial match to a word in the sentence. | <li>Sentence: "cathedral"</li><li>Word to Count: "cat"</li> | Word Count: 0  |





## Setup/Installation Requirements

* _Clone repository_
* _Download and install [.NET Core 1.1 SDK](https://www.microsoft.com/net/download/core)_
* _Download and install [Mono](http://www.mono-project.com/download/)_


## Technologies Used
* _C#_
* _.NET_
* _[Bootstrap](http://getbootstrap.com/getting-started/)_

### License

Copyright (c) 2017 **_Kaili Nishihira_**

*Licensed under the [MIT License](https://opensource.org/licenses/MIT)*
