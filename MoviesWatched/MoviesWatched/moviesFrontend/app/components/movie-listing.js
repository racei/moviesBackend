import Component from '@ember/component';
import {inject as service} from '@ember/service';

export default Component.extend({
    editing: false,
    movie: null,
    users: null,
    store: service(),
    actions:{
        deleteMovie(id){
            this.get('store').findRecord('movie', id).then(function(movie){
                movie.deleteRecord();
                movie.save();
            })
        },
        editMovie(){
            this.toggleProperty('editing');

        },
        saveMovie(movie){
            movie.save();
            this.toggleProperty('editing');
        },
        removeUserFromMovie(movie, user){
                movie.get('usersWatched').removeObject(user);
                movie.save();
        },
        addUserToMovie(movie, user){
            movie.get('usersWatched').addObject(user);
            movie.save();


        }


        
    }
});
