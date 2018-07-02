import Component from '@ember/component';
import {inject as service} from '@ember/service';

export default Component.extend({
    name: '',
    editing: false,
    store: service(),
    actions:{
        deleteUser(id){

            this.get('store').findRecord('user', id).then(function(user){
                user.deleteRecord();
                user.save();
            })
        },
        editUser(){
            this.toggleProperty('editing');
        },saveUser(id){
            let name = this.get('name');

            this.get('store').findRecord('user', id).then(function(user){
                user.set('name', name);
                user.save();
            })
            this.toggleProperty('editing');
        }

    }
});
