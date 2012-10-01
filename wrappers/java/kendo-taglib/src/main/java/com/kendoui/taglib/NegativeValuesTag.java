
package com.kendoui.taglib;

import javax.servlet.jsp.JspException;

@SuppressWarnings("serial")
public class NegativeValuesTag extends BaseTag /* interfaces *//* interfaces */ {

//>> Attributes

    @Override
    public int doEndTag() throws JspException {
        NegativeValues parent = (NegativeValues)findParentWithClass(NegativeValues.class);

        parent.setNegativeValues(this);

        return EVAL_PAGE;
    }

    public String getColor() {
        return (String)getProperty("color");
    }

    public void setColor(String value) {
        setProperty("color", value);
    }

    public boolean getVisible() {
        return (boolean)getProperty("visible");
    }

    public void setVisible(boolean value) {
        setProperty("visible", value);
    }

//<< Attributes
}
