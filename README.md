# AdventOfCode

This repository is devoted to the [Advent of Code](https://adventofcode.com/) event, to be able to add new solutions in an easily manageable way.



### Adding new day's solution
- Create a new class, implementing **AdventOfCode2021.DailyCodes.AbstractApp<T>** (Don't forget the constructor!)
- Add the new data resource to the **\Input** directory, named as "Day[number].txt" with two digits. (e.g Day01.txt, Day24.txt)
- Add an entry for the freshly implemented type in **AdventOfCode2021.AppFactory**
- run the app, enter given day's number upon prompt.
