using System.Collections.Generic;

namespace BusinessRules
{
    internal class VideoOrder : Order
    {
        private string _title;

        public VideoOrder(string title) :
            base()
        {
            _title = title;
            if (_title == "Learning To Ski")
            {
                PackingSlip.FirstAidVideoAttched = true;
            }
        }

    }
}