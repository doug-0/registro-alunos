<template>
  <v-data-table :headers="headers" :items="students" sort-by="id" class="elevation-1">
    <template v-slot:top>
      <v-toolbar flat>
        <v-toolbar-title>Lista de Alunos</v-toolbar-title>
        <v-divider class="mx-4" inset vertical></v-divider>
        <v-spacer></v-spacer>
        <v-dialog v-model="dialog" max-width="500px">
          <template v-slot:activator="{ on, attrs }">
            <v-btn color="primary" dark class="mb-2" v-bind="attrs" v-on="on">
              Adicionar novo registro
            </v-btn>
          </template>
          <v-card>
            <v-card-title>
              <span class="text-h5">{{ formTitle }}</span>
            </v-card-title>

            <v-card-text>
              <v-container>
                <v-row>
                  <v-col cols="12" sm="6" md="4">
                    <v-text-field v-model="editedItem.name" label="Nome do aluno">
                    </v-text-field>
                  </v-col>
                  <v-col cols="12" sm="6" md="4">
                    <v-text-field v-model="editedItem.email" label="E-mail"></v-text-field>
                  </v-col>
                  <v-col cols="12" sm="6" md="4">
                    <v-text-field v-model="editedItem.cpf" label="CPF"></v-text-field>
                  </v-col>
                </v-row>
              </v-container>
            </v-card-text>

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue darken-1" text @click="close">
                Cancelar
              </v-btn>
              <v-btn color="blue darken-1" text @click="save">
                Salvar
              </v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>
        <v-dialog v-model="dialogDelete" max-width="500px">
          <v-card>
            <v-card-title class="text-h6">Você tem certeza que quer excluir esse item?</v-card-title>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue darken-1" text @click="closeDelete">Não, quero voltar!</v-btn>
              <v-btn color="blue darken-1" text @click="deleteItemConfirm">Sim, exclua esse item!</v-btn>
              <v-spacer></v-spacer>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-toolbar>
    </template>
    <template v-slot:[`item.actions`]="{ item }">
      <v-icon small class="mr-2" @click="editItem(item)">
        mdi-pencil
      </v-icon>
      <v-icon small @click="deleteItem(item)">
        mdi-delete
      </v-icon>
    </template>
  </v-data-table>
</template>

<script>
import Students from '../services/students'
import { cpf } from 'cpf-cnpj-validator'

export default {
  async mounted() {
    try {
      const { data } = await Students.getAllStudents();

      return this.students.push(...data);
    } catch (error) {
      console.log(error)
    }
  },

  data: () => ({
    dialog: false,
    dialogDelete: false,
    headers: [
      {
        text: 'Registro Acadêmico',
        align: 'start',
        sortable: true,
        value: 'id',
      },
      { text: 'Nome', value: 'name' },
      { text: 'E-mail', value: 'email' },
      { text: 'CPF', value: 'cpf' },
      { text: 'Ações', value: 'actions' },
    ],
    students: [],
    editedIndex: -1,
    editedItem: {
      name: '',
      email: '',
      cpf: '',
    },
    defaultItem: {
      name: '',
      cpf: '',
    },
    deletedItem: '',
    renderComponent: false,
  }),

  computed: {
    formTitle() {
      return this.editedIndex === -1 ? 'Novo Registro' : 'Editar Registro'
    },
  },

  watch: {
    dialog(val) {
      val || this.close()
    },
    dialogDelete(val) {
      val || this.closeDelete()
    },
  },

  methods: {
    editItem(item) {
      this.editedIndex = this.students.indexOf(item)
      this.editedItem = Object.assign({}, item)
      this.dialog = true
    },

    deleteItem(item) {
      this.editedIndex = this.students.indexOf(item)
      this.editedItem = Object.assign({}, item)
      this.deletedItem = item;
      this.dialogDelete = true
    },

    deleteItemConfirm() {
      this.deletedStudent(this.deletedItem.id, this.deletedItem)

      this.closeDelete()

      return this.showAlert('delete');
    },

    close() {
      this.dialog = false
      this.$nextTick(() => {
        this.editedItem = Object.assign({}, this.defaultItem)
        this.editedIndex = -1
      })
    },

    closeDelete() {
      this.dialogDelete = false
      this.$nextTick(() => {
        this.editedItem = Object.assign({}, this.defaultItem)
        this.editedIndex = -1
      })
    },

    save() {
      // eslint-disable-next-line no-useless-escape
      const regexEmail = /^[a-z0-9._]+@[a-z0-9]+\.[a-z]+(\.[a-z]+)?$/i;

      if (this.editedItem.name === '' || this.editedItem.cpf.length !== 11 || !regexEmail.test(this.editedItem.email)) {
        return this.showAlert('warning');
      }

      if (this.editedIndex > -1) {
        const updatedStudent = {
          Name: this.editedItem.name,
          Email: this.editedItem.email,
          CPF: cpf.format(this.editedItem.cpf),
        }

        this.updateStudent(updatedStudent, this.editedItem.id);
      } else {
        const newStudent = {
          Name: this.editedItem.name,
          Email: this.editedItem.email,
          CPF: cpf.format(this.editedItem.cpf),
        }

        this.createStudent(newStudent)
      }
      this.close()
    },

    reaload() {
      window.location.reload()
    },

    showAlert(type) {
      switch (type) {
        case 'success':
          return this.$swal({
            title: 'Feito!',
            text: 'Registro salvo!',
            icon: 'success',
            showConfirmButton: false,
            timer: 1000
          });
        case 'warning':
          return this.$swal({
            title: 'Opa!',
            text: 'Verifique se todos os campos estão corretos! Nome, e-mail e CPF (11 digitos)!',
            icon: 'warning',
          });
        case 'delete':
          return this.$swal({
            title: 'Feito!',
            text: 'Registro excluído!',
            icon: 'success',
            timer: 1000
          });
      }
    },

    async getStudents() {
      try {
        const { data } = await Students.getAllStudents();

        return this.students.push(...data);
      } catch (error) {
        console.log(error)
      }
    },

    async createStudent(student) {
      try {
        await Students.createStudents(student);

        this.showAlert('success');
        setTimeout(() => this.reaload(), 950)
      } catch (error) {
        console.log(error);
      }
    },

    async updateStudent(student, id) {
      try {
        await Students.updateStudent(student, id);

        this.showAlert('success');
        setTimeout(() => this.reaload(), 950)
      } catch (error) {
        console.log(error);
      }
    },

    async deletedStudent(id, student) {
      const data = {
        Name: student.name,
        Email: student.email,
        CPF: student.cpf,
      }

      try {
        await Students.deletedStudent(id, data);

        this.showAlert('delete');
        setTimeout(() => this.reaload(), 950)
      } catch (error) {
        console.log(error)
      }
    }
  },
}
</script>