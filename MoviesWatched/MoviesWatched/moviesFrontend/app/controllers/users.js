import Controller from '@ember/controller';

export default Controller.extend({
    name:'',
    actions:{
        addUser(){
            let newUser = this.get('store').createRecord('user',{name:this.name});
            newUser.save();
            this.set('name', '');
        }
    }
});
