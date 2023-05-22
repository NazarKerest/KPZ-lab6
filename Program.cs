using BlackJack;
ComputerPlayer.IOpponentStrategy opponentStrategy = new ComputerPlayer.RandomOpponentStrategy();
ComputerPlayer.IComputerPlayerStrategy computerPlayerStrategy = new ComputerPlayer.CautiousComputerPlayerStrategy();
Game game = new Game(opponentStrategy, computerPlayerStrategy);
game.Start();