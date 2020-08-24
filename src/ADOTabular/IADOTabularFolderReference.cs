﻿using System.Collections.Generic;

namespace ADOTabular
{

	public enum FolderReferenceType
    {
        None,
		Folder,
		Column
    }
    public interface IADOTabularFolderReference : IADOTabularObjectReference
    {
        List<IADOTabularObjectReference> FolderItems { get; }
     
		FolderReferenceType ReferenceType { get; }
    }
}
