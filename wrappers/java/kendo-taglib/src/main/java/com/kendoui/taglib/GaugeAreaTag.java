
package com.kendoui.taglib;

import javax.servlet.jsp.JspException;

@SuppressWarnings("serial")
public class GaugeAreaTag extends BaseTag /* interfaces */implements Border/* interfaces */ {

//>> Attributes

    @Override
    public int doEndTag() throws JspException {
        GaugeArea parent = (GaugeArea)findParentWithClass(GaugeArea.class);

        parent.setGaugeArea(this);

        return EVAL_PAGE;
    }

    @Override
    public void setBorder(BorderTag value) {
        setProperty("border", value);
    }

    public int getHeight() {
        return (int)getProperty("height");
    }

    public void setHeight(int value) {
        setProperty("height", value);
    }

    public int getMargin() {
        return (int)getProperty("margin");
    }

    public void setMargin(int value) {
        setProperty("margin", value);
    }

    public int getWidth() {
        return (int)getProperty("width");
    }

    public void setWidth(int value) {
        setProperty("width", value);
    }

//<< Attributes
}
