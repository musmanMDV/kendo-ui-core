
package com.kendoui.taglib;

import javax.servlet.jsp.JspException;

@SuppressWarnings("serial")
public class EditableTag extends BaseTag /* interfaces *//* interfaces */ {

//>> Attributes

    @Override
    public int doEndTag() throws JspException {
        Editable parent = (Editable)findParentWithClass(Editable.class);

        parent.setEditable(this);

        return EVAL_PAGE;
    }

    public boolean getDestroy() {
        return (boolean)getProperty("destroy");
    }

    public void setDestroy(boolean value) {
        setProperty("destroy", value);
    }

    public String getMode() {
        return (String)getProperty("mode");
    }

    public void setMode(String value) {
        setProperty("mode", value);
    }

    public String getTemplate() {
        return (String)getProperty("template");
    }

    public void setTemplate(String value) {
        setProperty("template", value);
    }

    public boolean getUpdate() {
        return (boolean)getProperty("update");
    }

    public void setUpdate(boolean value) {
        setProperty("update", value);
    }

//<< Attributes
}
