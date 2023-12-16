using System;

class Comment{
    private string _namePerson;
    private string _commentDescription;

    public Comment(string name, string description){
        this._namePerson = name;
        this._commentDescription = description;
    }

    public string GetName(){
        return this._namePerson;
    }

    public string GetComment(){
        return this._commentDescription;
    }
}