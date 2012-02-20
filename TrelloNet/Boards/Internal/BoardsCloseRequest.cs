using RestSharp;

namespace TrelloNet.Internal
{
	internal class BoardsCloseRequest : BoardRequest
	{
		public BoardsCloseRequest(IBoardId board)
			: base(board, "closed", Method.PUT)
		{
			AddParameter("value", "true");
		}
	}
}