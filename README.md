# 🎮 Rock-Paper-Scissors Game

## 📝 Overview
This is a simple console-based Rock-Paper-Scissors game implemented in C#. The player competes against the computer in an unlimited round-based game where they can enter their choice and see the result instantly. The game keeps track of the score and allows the player to exit at any time.

## ⭐ Features
- 🎭 Allows the user to play Rock-Paper-Scissors against the computer.
- ✅ Validates user input and provides feedback for invalid choices.
- 💻 Displays the computer's choice for each round.
- 📊 Tracks and displays the score after each round.
- 🚪 Allows the user to exit the game by typing `exit`.

## 🚀 How to Run
1. Ensure you have .NET installed on your system.
2. Copy the `Program.cs` file into a new C# Console Application project.
3. Open a terminal or command prompt and navigate to the project directory.
4. Compile and run the program using the following commands:
   ```sh
   dotnet run
   ```
5. Follow the on-screen instructions to play the game.

## 🎮 Gameplay Instructions
1. When prompted, enter one of the following choices:
   - ✊ `rock`
   - ✋ `paper`
   - ✌️ `scissors`
2. The computer will randomly select its choice.
3. The winner is determined based on the standard rules:
   - ✊ Rock beats ✌️ Scissors
   - ✋ Paper beats ✊ Rock
   - ✌️ Scissors beats ✋ Paper
4. The score is updated after each round.
5. To exit the game, type `exit`.

## 📌 Example Output
```
Welcome to Rock-Paper-Scissors!
Enter Rock, Paper, or Scissors (or type 'exit' to quit): rock
Computer chose: scissors
You win!
Score - You: 1, Computer: 0

Enter Rock, Paper, or Scissors (or type 'exit' to quit): paper
Computer chose: rock
You win!
Score - You: 2, Computer: 0

Enter Rock, Paper, or Scissors (or type 'exit' to quit): exit
Thanks for playing! Final Score - You: 2, Computer: 0
```

## 📜 License
This project is open-source and can be used or modified freely.

## 👨‍💻 Author
Developed by Prince Ngwako Mashumu

