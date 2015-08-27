using AjaxControlToolkit.Design;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxControlToolkit {

    /// <summary>
    /// The ColorPicker extender enables you to display a pop-up color picker when the focus is moved to an input element.
    /// You can attach the ColorPicker extender to any ASP.NET TextBox control. It provides client-side color-picking
    /// functionality with UI in a popup control. Optionally, you can specify a button to display the color-picker popup and
    /// a control that previews a color from the color palette. You can also provide a TextBox control where users can enter a
    /// color value; the ColorPicker extender can display a custom color even if the color is not in the default color-picker palette.
    /// </summary>
    [RequiredScript(typeof(CommonToolkitScripts), 0)]
    [RequiredScript(typeof(PopupExtender), 1)]
    [RequiredScript(typeof(ThreadingScripts), 2)]
    [TargetControlType(typeof(TextBox))]
    [ClientCssResource(Constants.ColorPickerName)]
    [ClientScriptResource("Sys.Extended.UI.ColorPickerBehavior", Constants.ColorPickerName)]
    [ToolboxBitmap(typeof(ToolboxIcons.Accessor), Constants.ColorPickerName + Constants.IconPostfix)]
    [Designer(typeof(ColorPickerExtenderDesigner))]
    public class ColorPickerExtender : ExtenderControlBase {
        /// <summary>
        /// Specifies whether the ColorPicker behavior is available for the current element.
        /// </summary>
        [DefaultValue(true)]
        [ExtenderControlProperty]
        [ClientPropertyName("enabled")]
        public virtual bool EnabledOnClient {
            get { return GetPropertyValue("EnabledOnClient", true); }
            set { SetPropertyValue("EnabledOnClient", value); }
        }

        /// <summary>
        ///  The ID of a control to use to display the color-picker popup.
        /// </summary>
        /// <remarks>
        /// If this value is not set, the color picker will pop up when the TextBox control that is represented by TargetControlID receives focus.
        /// </remarks>
        [DefaultValue("")]
        [ExtenderControlProperty]
        [ClientPropertyName("button")]
        [ElementReference]
        [IDReferenceProperty]
        public virtual string PopupButtonID {
            get { return GetPropertyValue("PopupButtonID", String.Empty); }
            set { SetPropertyValue("PopupButtonID", value); }
        }

        /// <summary>
        /// The ID of a control to use to display the selected color.
        /// </summary>
        /// <remarks>
        /// If this value is set and the color picker popup is open, the background color of the specified control
        /// displays the color that the mouse pointer is over. If this value is not set, the selected color is not displayed.
        /// </remarks>
        [DefaultValue("")]
        [ExtenderControlProperty]
        [ClientPropertyName("sample")]
        [ElementReference]
        [IDReferenceProperty]
        public virtual string SampleControlID {
            get { return GetPropertyValue("SampleControlID", String.Empty); }
            set { SetPropertyValue("SampleControlID", value); }
        }

        /// <summary>
        /// Indicates where the color picker popup should appear relative to the TextBox control that is being extended.
        /// </summary>
        /// <remarks>
        /// Values can be BottomLeft, BottomRight, TopLeft, TopRight, Left, or Right. The default is BottomLeft.
        /// </remarks>
        [ExtenderControlProperty]
        [ClientPropertyName("popupPosition")]
        [DefaultValue(PositioningMode.BottomLeft)]
        [Description("Indicates where you want the color picker displayed relative to the textbox.")]
        public virtual PositioningMode PopupPosition {
            get { return GetPropertyValue("PopupPosition", PositioningMode.BottomLeft); }
            set { SetPropertyValue("PopupPosition", value); }
        }

        /// <summary>
        /// The color value that the ColorPicker extender is initialized with.
        /// </summary>
        [DefaultValue("")]
        [ExtenderControlProperty]
        [ClientPropertyName("selectedColor")]
        public string SelectedColor {
            get { return GetPropertyValue("SelectedColor", String.Empty); }
            set { SetPropertyValue("SelectedColor", value); }
        }

        /// <summary>
        /// A JavaScript function that will be called when the showing event is raised.
        /// </summary>
        [DefaultValue("")]
        [ExtenderControlEvent]
        [ClientPropertyName("showing")]
        public virtual string OnClientShowing {
            get { return GetPropertyValue("OnClientShowing", String.Empty); }
            set { SetPropertyValue("OnClientShowing", value); }
        }

        /// <summary>
        /// A JavaScript function that will be called when the shown event is raised.
        /// </summary>
        [DefaultValue("")]
        [ExtenderControlEvent]
        [ClientPropertyName("shown")]
        public virtual string OnClientShown {
            get { return GetPropertyValue("OnClientShown", String.Empty); }
            set { SetPropertyValue("OnClientShown", value); }
        }

        /// <summary>
        /// A JavaScript function that will be called when the hiding event is raised.
        /// </summary>
        [DefaultValue("")]
        [ExtenderControlEvent]
        [ClientPropertyName("hiding")]
        public virtual string OnClientHiding {
            get { return GetPropertyValue("OnClientHiding", String.Empty); }
            set { SetPropertyValue("OnClientHiding", value); }
        }

        /// <summary>
        /// A JavaScript function that will be called when the hidden event is raised.
        /// </summary>
        [DefaultValue("")]
        [ExtenderControlEvent]
        [ClientPropertyName("hidden")]
        public virtual string OnClientHidden {
            get { return GetPropertyValue("OnClientHidden", String.Empty); }
            set { SetPropertyValue("OnClientHidden", value); }
        }

        /// <summary>
        /// A JavaScript function that will be called when the colorSelectionChanged event is raised.
        /// </summary>
        [DefaultValue("")]
        [ExtenderControlEvent]
        [ClientPropertyName("colorSelectionChanged")]
        public virtual string OnClientColorSelectionChanged {
            get { return GetPropertyValue("OnClientColorSelectionChanged", String.Empty); }
            set { SetPropertyValue("OnClientColorSelectionChanged", value); }
        }
    }

}
