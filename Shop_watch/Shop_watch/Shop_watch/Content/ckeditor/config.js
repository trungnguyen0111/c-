﻿/*
Copyright (c) 2003-2011, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function( config )
{
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
	// config.uiColor = '#AADC6E';
    config.language = "en";
    config.filebrowserBrowseUrl = "/Content/ckfinder/ckfinder.html";
    config.filebrowserImageUrl = "/Content/ckfinder/ckfinder.html?type=Images";
    config.filebrowserFlashUrl = "/Content/ckfinder/ckfinder.html?type=Flash";
    config.filebrowserUploadUrl = "/Content/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload & type=Files";
    config.filebrowserImageUploadUrl = "/Content/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload & type=Images";
    config.filebrowserFlashUploadUrl = "/Content/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload & type=Flash";
};
