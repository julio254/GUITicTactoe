// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace GUITicTacToe
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton ImageButton1 { get; set; }

		[Outlet]
		AppKit.NSButton ImageButton2 { get; set; }

		[Outlet]
		AppKit.NSButton ImageButton3 { get; set; }

		[Outlet]
		AppKit.NSButton ImageButton4 { get; set; }

		[Outlet]
		AppKit.NSButton ImageButton5 { get; set; }

		[Outlet]
		AppKit.NSButton ImageButton6 { get; set; }

		[Outlet]
		AppKit.NSButton ImageButton7 { get; set; }

		[Outlet]
		AppKit.NSButton ImageButton8 { get; set; }

		[Outlet]
		AppKit.NSButton ImageButton9 { get; set; }

		[Outlet]
		AppKit.NSTextField MessageOfWinnerText { get; set; }

		[Outlet]
		AppKit.NSButton PlayAgainButton { get; set; }

		[Outlet]
		AppKit.NSTextField PlayerOLabel { get; set; }

		[Outlet]
		AppKit.NSTextField PlayerTurnText { get; set; }

		[Outlet]
		AppKit.NSTextField PlayerXLabel { get; set; }

		[Outlet]
		AppKit.NSButton ResetButton { get; set; }

		[Action ("ImageButton1Click:")]
		partial void ImageButton1Click (Foundation.NSObject sender);

		[Action ("ImageButton2Click:")]
		partial void ImageButton2Click (Foundation.NSObject sender);

		[Action ("ImageButton3Click:")]
		partial void ImageButton3Click (Foundation.NSObject sender);

		[Action ("ImageButton4Click:")]
		partial void ImageButton4Click (Foundation.NSObject sender);

		[Action ("ImageButton5Click:")]
		partial void ImageButton5Click (Foundation.NSObject sender);

		[Action ("ImageButton6Click:")]
		partial void ImageButton6Click (Foundation.NSObject sender);

		[Action ("ImageButton7Click:")]
		partial void ImageButton7Click (Foundation.NSObject sender);

		[Action ("ImageButton8Click:")]
		partial void ImageButton8Click (Foundation.NSObject sender);

		[Action ("ImageButton9Click:")]
		partial void ImageButton9Click (Foundation.NSObject sender);

		[Action ("PlayAgainButtonClick:")]
		partial void PlayAgainButtonClick (Foundation.NSObject sender);

		[Action ("ResetButtonClick:")]
		partial void ResetButtonClick (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ImageButton1 != null) {
				ImageButton1.Dispose ();
				ImageButton1 = null;
			}

			if (ImageButton2 != null) {
				ImageButton2.Dispose ();
				ImageButton2 = null;
			}

			if (ImageButton3 != null) {
				ImageButton3.Dispose ();
				ImageButton3 = null;
			}

			if (ImageButton4 != null) {
				ImageButton4.Dispose ();
				ImageButton4 = null;
			}

			if (ImageButton5 != null) {
				ImageButton5.Dispose ();
				ImageButton5 = null;
			}

			if (ImageButton6 != null) {
				ImageButton6.Dispose ();
				ImageButton6 = null;
			}

			if (ImageButton7 != null) {
				ImageButton7.Dispose ();
				ImageButton7 = null;
			}

			if (ImageButton8 != null) {
				ImageButton8.Dispose ();
				ImageButton8 = null;
			}

			if (ImageButton9 != null) {
				ImageButton9.Dispose ();
				ImageButton9 = null;
			}

			if (MessageOfWinnerText != null) {
				MessageOfWinnerText.Dispose ();
				MessageOfWinnerText = null;
			}

			if (PlayAgainButton != null) {
				PlayAgainButton.Dispose ();
				PlayAgainButton = null;
			}

			if (PlayerTurnText != null) {
				PlayerTurnText.Dispose ();
				PlayerTurnText = null;
			}

			if (ResetButton != null) {
				ResetButton.Dispose ();
				ResetButton = null;
			}

			if (PlayerXLabel != null) {
				PlayerXLabel.Dispose ();
				PlayerXLabel = null;
			}

			if (PlayerOLabel != null) {
				PlayerOLabel.Dispose ();
				PlayerOLabel = null;
			}
		}
	}
}
