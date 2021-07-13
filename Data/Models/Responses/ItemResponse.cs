using S_3D.Test.App.Data.Interfaces;

namespace _3D.Test.App.Data.Models.Responses
{
    /// <summary>
    /// This is an example of a Generic class that you will gain an understanding of as you progress
    /// through the training.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ItemResponse<T> : SuccessResponse, IItemResponse
    {
        public T Item { get; set; }

        object IItemResponse.Item { get { return this.Item; } }
    }
}