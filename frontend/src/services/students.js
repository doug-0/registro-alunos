import { api } from './config';

export default {
  getAllStudents: async () => {
    return await api.get('students');
  },

  createStudents: async (data) => {
    return await api.post('students', data);
  },

  updateStudent: async (data, id) => {
    return await api.put(`students/${id}`, data);
  },

  deletedStudent: async (id, student) => {
    return await api.delete(`students/${id}`, { data: student });
  }
};
