using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using System;
using System.Collections.Generic;

namespace EpiserverProject.Business.CustomProperties
{
    [EditorDescriptorRegistration(TargetType = typeof(string), UIHint = "Topic")]
    public class TopicDescriptor : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            SelectionFactoryType = typeof(TopicSelectionFactory);
            ClientEditingClass = "epi-cms/contentediting/editors/SelectionEditor";
            base.ModifyMetadata(metadata, attributes);
        }
    }
}