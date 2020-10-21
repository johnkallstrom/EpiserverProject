using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;

namespace EpiserverProject.Business.CustomProperties
{
    public class TopicSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var selections = new List<ISelectItem>
            {
                new SelectItem { Text = TopicTypes.Culture, Value = TopicTypes.Culture },
                new SelectItem { Text = TopicTypes.Entertainment, Value = TopicTypes.Entertainment },
                new SelectItem { Text = TopicTypes.Music, Value = TopicTypes.Music },
                new SelectItem { Text = TopicTypes.Technology, Value = TopicTypes.Technology },
            };

            return selections;
        }
    }
}