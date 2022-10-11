<template>
  <students-table />
</template>

<script>
import StudentsTable from '../components/TableStudents.vue'

export default {
  // eslint-disable-next-line vue/multi-word-component-names
  name: 'Home',

  components: {
    StudentsTable,
  },
}
</script>
