import DS from 'ember-data';

export default DS.Model.extend({
    title: DS.attr('string'),
    yearReleased: DS.attr('number'),
    length: DS.attr('string'),
    usersWatched: DS.hasMany('user'),

});
