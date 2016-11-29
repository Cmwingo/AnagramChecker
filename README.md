## Specs

| Behavior - Plain English                                       | Input                                                     | Output       |
|----------------------------------------------------------------|-----------------------------------------------------------|--------------|
| Can determine if one word is an anagram of another word        | User Word: bread User Word List: beard                    | beard        |
| Can determine if multiple words are an anagram of another word | User Word: bread User Word List: beard, bared             | beard, bared |
| Will NOT return words in the word list that aren't anagrams    | User Word: bread User Word List: beard, bared, kite, fish | beard, bared |
