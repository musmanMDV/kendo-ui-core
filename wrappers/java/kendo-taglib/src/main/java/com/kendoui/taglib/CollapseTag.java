
package com.kendoui.taglib;

import javax.servlet.jsp.JspException;

@SuppressWarnings("serial")
public class CollapseTag extends BaseTag /* interfaces *//* interfaces */ {

//>> Attributes

    @Override
    public int doEndTag() throws JspException {
        Collapse parent = (Collapse)findParentWithClass(Collapse.class);

        parent.setCollapse(this);

        return EVAL_PAGE;
    }

    public int getDuration() {
        return (int)getProperty("duration");
    }

    public void setDuration(int value) {
        setProperty("duration", value);
    }

    public String getEffects() {
        return (String)getProperty("effects");
    }

    public void setEffects(String value) {
        setProperty("effects", value);
    }

//<< Attributes
}
