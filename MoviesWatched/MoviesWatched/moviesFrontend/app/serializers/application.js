import DS from 'ember-data';

export default DS.JSONSerializer.extend(DS.EmbeddedRecordsMixin, { 
  serialize: function(record, options) {
    options = options || {includeId: true};
    return this._super(record, options);
  },
  attrs:{
    usersWatched:{embedded:'always'}
  }

});
