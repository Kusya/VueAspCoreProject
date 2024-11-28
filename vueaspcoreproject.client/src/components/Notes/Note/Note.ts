
// type Notes = {
//   id: number;
//   name: string;
//   content: string;
//   color: string;
// }[];

// interface Data {
//     loading: boolean,
//     data: null //| Forecasts
// }

export default {
  props: {
    data: Object,
  },
  template: `<div class="card" :style="data.color" >
              <div style="font-weight:700">{{data.name}}</div>
              <div>{{data.content}}</div>
            </div>`,
  created() {
    // fetch the data when the view is created and the data is
    // already being observed
    if(!this.data?.color){
      this.data.color = 'black';
    }
    let colorstr = 'color: '+this.data.color +';';
    this.data.color = colorstr;
  },
  watch: {
    // call again the method if the route changes
    //$route: "fetchData",
  },
  methods: {
  },
};
