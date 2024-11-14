//import { defineComponent } from "vue";
//import NoteDashboard from "../NotesDashboardPage/NoteDashboard.vue";

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

export default ({
  
  props:{
    data: Object
  },
  template: `<div style="font-weight:700">{{data.noteName}}</div>
  <div>{{data.noteContent}}</div>`,
  created() {
    debugger;
    // fetch the data when the view is created and the data is
    // already being observed
    // this.fetchData();
  },
  watch: {
    // call again the method if the route changes
    //$route: "fetchData",
  },
  methods: {
    // fetchData(): void {
    //   this.post = null;
    //   this.loading = true;

      // fetch("weatherforecast")
      //   .then((r) => r.json())
      //   .then((json) => {
      //     this.post = json as Forecasts;
      //     this.loading = false;
      //     return;
      //   });
    // },
  },
});
