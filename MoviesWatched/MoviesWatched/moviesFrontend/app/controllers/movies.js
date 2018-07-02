import Controller from '@ember/controller';

export default Controller.extend({

    title: '',
    yearReleased: '',
    length: '',
    init() {
        this._super(...arguments);
        this.errors = [];
    },
    actions:{
        addMovie(){
            this.set('errors', []);
            let newErrors = [];
            if(this.title.length == 0){
                newErrors.push( "Title must be longer than 0 characters");
            }
            let regexLength = /^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$/;
            if(!regexLength.exec(this.length)){
                newErrors.push( "Movie length must be in HH:MM:SS format");
            }
            let regexYear = /^\d{4}$/;
            if(!regexYear.exec(this.yearReleased)){
                newErrors.push("Year must be entered");
            }
            if(newErrors != []){
                this.set('errors', newErrors);
                return;
            }

            let newMovie = this.get('store').createRecord('movie',{title:this.title, yearReleased:this.yearReleased, length:this.length});
            this.set('title', '');
            this.set('yearReleased', '');
            this.set('length', '')
            newMovie.save();
        },
    }
});
