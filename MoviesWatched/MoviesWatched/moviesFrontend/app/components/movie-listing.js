import Component from '@ember/component';
import { inject as service } from '@ember/service';
import { computed } from '@ember/object';

export default Component.extend({
    editing: false,
    movie: null,
    users: null,
  usersNotWatched: computed('movie.usersWatched.[]', function () {
    let allUsers = this.get('users');
    let movie = this.get('movie');
    let ids = movie.get('usersWatched').map((user) => user.get('id'));
    let newUsers = [];
    allUsers.forEach(function (ele) {
      var userID = ele.get('id');
      if (!ids.includes(userID)) {
        newUsers.push(ele);
      }
    });
    return newUsers;
  }),
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


        },


        
    }
});
