using System;

namespace FBC.WebApi.Data {
    public class DbEntity {
        public int Id;
        public DateTime CreatedDttm;
        public DateTime UpdateDttm;
        public int CreatedById;
        public int UpdatedById;
        public bool _dirty;

        public bool IsDirty() {
            return _dirty;
        }
    }
}